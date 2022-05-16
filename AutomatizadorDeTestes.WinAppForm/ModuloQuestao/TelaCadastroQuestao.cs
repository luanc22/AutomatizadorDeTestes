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


namespace AutomatizadorDeTestes.WinAppForm
{
    public partial class TelaCadastroQuestao : Form
    {
        private Questao questao;
        char[] alternativas = new char[] { 'A', 'B', 'C', 'D', 'E' };
        List<string> alternativasQuestao = new List<string>();
        char respostaCorreta;
        int countAlternativa = 0;

        public TelaCadastroQuestao(List<Disciplina> disciplinas, List<Materia> materias)
        {
            InitializeComponent();
            CarregarDisciplinas(disciplinas);
            CarregarMaterias(materias);
        }

        public Func<Questao, ValidationResult> GravarRegistro { get; set; }

        public Questao Questao
        {
            get { return questao; }
            set
            {
                questao = value;

                txtNumQuest.Text = questao.Id.ToString();
                cbBoxDisciplina.SelectedItem = questao.Disciplina;
                cbBoxMateria.SelectedItem = questao.Materia;
                txtDescricao.Text = questao.Descricao;
            }
        }

        private void TelaCadastroQuestao_Load(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroQuestao_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (countAlternativa == 5) 
            {
                bool contemCorreta = false;
                foreach (var item in alternativasQuestao)
                {
                    if (item.Contains("[CORRETA]"))
                    {
                        contemCorreta = true;
                    }
                }

                if (contemCorreta)
                {
                    questao.Id = int.Parse(txtNumQuest.Text);
                    questao.Descricao = txtDescricao.Text;
                    questao.Materia = (Materia)cbBoxMateria.SelectedItem;
                    questao.Disciplina = (Disciplina)cbBoxDisciplina.SelectedItem;
                    questao.Resposta = respostaCorreta;
                    questao.Alternativas = alternativasQuestao;

                    var resultadoValidacao = GravarRegistro(questao);

                    if (resultadoValidacao.IsValid == false)
                    {
                        string erro = resultadoValidacao.Errors[0].ErrorMessage;

                        TelaPrincipal.Instancia.AtualizarRodape(erro);

                        MessageBox.Show("Verifique os campos preenchidos e tente novamente",
                        "Cadastro de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Você deve adicionar uma alternativa correta",
                    "Cadastro de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    return;
                }

            }
            else
            {
                MessageBox.Show("Você deve adicionar 5 alternativas à questão",
                "Cadastro de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            this.Close();


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAlternativa.Text) && countAlternativa <= 4)
            {
                if (chkCorreta.Checked)
                {
                    lstBoxAlternativasAdicionadas.Items.Add(alternativas[countAlternativa] + ") " + txtAlternativa.Text + " [CORRETA] ");
                    respostaCorreta = alternativas[countAlternativa];
                    chkCorreta.Checked = false;
                    chkCorreta.Enabled = false;
                    alternativasQuestao.Add(alternativas[countAlternativa] + ") " + txtAlternativa.Text + " [CORRETA] ");
                    txtAlternativa.Clear();

                }
                else
                {
                    lstBoxAlternativasAdicionadas.Items.Add(alternativas[countAlternativa] + ") " + txtAlternativa.Text);
                    alternativasQuestao.Add(alternativas[countAlternativa] + ") " + txtAlternativa.Text);
                }

                countAlternativa++;
                txtAlternativa.Clear();
            }
            else
            {
                MessageBox.Show("Não adicione alternativas vazias.",
                "Cadastro de Alternativas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
