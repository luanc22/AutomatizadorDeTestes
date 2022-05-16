using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using AutomatizadorDeTestes.Dominio.ModuloDisciplina;
using AutomatizadorDeTestes.Dominio.ModuloMateria;
using AutomatizadorDeTestes.Dominio.ModuloQuestao;
using AutomatizadorDeTestes.Dominio.ModuloTeste;
using AutomatizadorDeTestes.WinAppForm.Compartilhado;


namespace AutomatizadorDeTestes.WinAppForm.ModuloTeste
{
    public partial class TelaCadastroTeste : Form
    {
        private Teste teste;
        IRepositorioQuestao repositorioQuestao;
        List<Questao> questoesTeste = new List<Questao>();
        ValidadorRegex validador = new ValidadorRegex();
        private List<Materia> materias;

        public TelaCadastroTeste(IRepositorioQuestao repositorioQuestao, List<Questao> questoes, List<Disciplina> disciplinas, List<Materia> materias)
        {
            this.repositorioQuestao = repositorioQuestao;
            InitializeComponent();
            CarregarDisciplinas(disciplinas);
            CarregarMaterias(materias);
        }

        public Func<Teste, ValidationResult> GravarRegistro { get; set; }

        public Teste Teste
        {
            get { return teste; }
            set
            {
                teste = value;

                txtNumTeste.Text = teste.Id.ToString();
                txtTituloTeste.Text = teste.Titulo;
                cbBoxDisciplina.SelectedItem = teste.Disciplina;
                cbBoxMateria.SelectedItem = teste.Materia;
                dtTimeTeste.Value = teste.Data;
                txtQtdQuestoes.Text = teste.NumeroQuestoes.ToString();
            }
        }

        private void TelaCadastroTeste_Load(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroTeste_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipal.Instancia.AtualizarRodape("");
        }

        private void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cbBoxDisciplina.Items.Clear();

            foreach (var item in disciplinas)
            {
                cbBoxDisciplina.Items.Add(item);
            }
        }

        private void CarregarMaterias(List<Materia> materias)
        {
            cbBoxMateria.Items.Clear();

            foreach (var item in materias)
            {
                cbBoxMateria.Items.Add(item);
            }
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            btnSortear.Enabled = false;

            int contadorQuestoes = 1;
            var random = new Random();

            if (chkRecuperacao.Checked)
            {
                var questoes = repositorioQuestao.SelecionarTodos().Where(x => x.Disciplina.Nome == cbBoxDisciplina.Text);

                var questoesAleatorias = questoes.OrderBy(item => random.Next()).ToList();

                if (int.Parse(txtQtdQuestoes.Text) > questoes.Count())
                {
                    MessageBox.Show("Número de questões insuficientes da matéria ou disciplina para serem geradas no teste.",
                    "Cadastro de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnSortear.Enabled = true;
                    return;
                }

                for (int i = 0; i < int.Parse(txtQtdQuestoes.Text); i++)
                {
                    questoesTeste.Add(questoesAleatorias.ElementAt(i));
                }

                lstBoxQuestoes.Items.Clear();

                foreach (var item in questoesTeste)
                {
                    lstBoxQuestoes.Items.Add(contadorQuestoes + "- " + item.ToString());
                    contadorQuestoes++;
                }
            }
            else
            {
                var disciplinaQuestoes = repositorioQuestao.SelecionarTodos()
                                .Where(x => x.Disciplina.Nome == cbBoxDisciplina.Text)
                                .Where(x => x.Materia.Nome == cbBoxMateria.Text)
                                .ToList();

                var disciplinaQuestoesEmbaralhadas = disciplinaQuestoes.OrderBy(item => random.Next()).ToList();

                if (int.Parse(txtQtdQuestoes.Text) > disciplinaQuestoes.Count())
                {
                    MessageBox.Show("Número de questões insuficientes da matéria ou disciplina para serem geradas no teste.",
                    "Cadastro de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnSortear.Enabled = true;
                    return;
                }

                for (int i = 0; i < int.Parse(txtQtdQuestoes.Text); i++)
                {
                    questoesTeste.Add(disciplinaQuestoesEmbaralhadas.ElementAt(i));
                }

                lstBoxQuestoes.Items.Clear();

                foreach (var item in questoesTeste)
                {
                    lstBoxQuestoes.Items.Add(contadorQuestoes + "- " + item.ToString());
                    contadorQuestoes++;
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (validador.Numeros(txtNumTeste.Text))
            {
                teste.Id = int.Parse(txtNumTeste.Text);
                teste.Titulo = txtTituloTeste.Text;
                teste.NumeroQuestoes = int.Parse(txtQtdQuestoes.Text);
                teste.Disciplina = (Disciplina)cbBoxDisciplina.SelectedItem;
                teste.Data = dtTimeTeste.Value.Date;
                teste.Questoes = questoesTeste;
                try
                {
                    teste.Materia = (Materia)cbBoxMateria.SelectedItem;
                }
                catch
                {
                    Materia novaMateria = new Materia();
                    novaMateria.Nome = "Todas";
                    teste.Materia = novaMateria;

                }

                var resultadoValidacao = GravarRegistro(teste);

                if (resultadoValidacao.IsValid == false)
                {
                    string erro = resultadoValidacao.Errors[0].ErrorMessage;

                    TelaPrincipal.Instancia.AtualizarRodape(erro);

                    MessageBox.Show("Campos preenchidos incorretamente.",
                    "Geração de Testes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("A quantidade de questões pode conter apenas números!",
                "Cadastro de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            this.Close();
        }

        private void chkRecuperacao_MouseClick(object sender, MouseEventArgs e)
        {
            cbBoxMateria.Items.Add("Todas");
            int index = cbBoxMateria.Items.Count;
            cbBoxMateria.SelectedIndex = index - 1;
            cbBoxMateria.Enabled = false;
            chkRecuperacao.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
