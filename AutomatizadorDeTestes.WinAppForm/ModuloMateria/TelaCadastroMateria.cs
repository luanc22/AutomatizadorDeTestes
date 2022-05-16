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
using AutomatizadorDeTestes.Dominio.ModuloMateria;
using AutomatizadorDeTestes.Dominio.ModuloDisciplina;
using AutomatizadorDeTestes.WinAppForm.Compartilhado;


namespace AutomatizadorDeTestes.WinAppForm.ModuloMateria
{
    public partial class TelaCadastroMateria : Form
    {
        private Materia materia;
        private Disciplina disciplinaSelecionada;
        ValidadorRegex validador = new ValidadorRegex();

        public TelaCadastroMateria(List<Disciplina> disciplinas)
        {
            InitializeComponent();
            CarregarDisciplinas(disciplinas);
            CarregarSeries();
        }

        public Func<Materia, ValidationResult> GravarRegistro { get; set; }

        public Materia Materia
        {
            get { return materia; }
            set
            {
                materia = value;

                txtNumMat.Text = materia.Id.ToString();
                txtNomeMat.Text = materia.Nome;
                cbBoxDisciplina.SelectedItem = materia.Disciplina;
                cbBoxSerie.SelectedItem = materia.Serie;
            }
        }

        private void TelaCadastroMateria_Load(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroMateria_FormClosing(object sender, FormClosingEventArgs e)
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

        private void CarregarSeries()
        {
            cbBoxSerie.Items.Clear();
            cbBoxSerie.Items.Add("1ª Série");
            cbBoxSerie.Items.Add("2ª Série");
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (validador.Letras(txtNomeMat.Text))
            {
                materia.Id = int.Parse(txtNumMat.Text);
                materia.Nome = txtNomeMat.Text;
                materia.Serie = cbBoxSerie.Text;
                materia.Disciplina = (Disciplina)cbBoxDisciplina.SelectedItem;

                var resultadoValidacao = GravarRegistro(materia);

                if (resultadoValidacao.IsValid == false)
                {
                    string erro = resultadoValidacao.Errors[0].ErrorMessage;

                    TelaPrincipal.Instancia.AtualizarRodape(erro);

                    DialogResult = DialogResult.None;

                    MessageBox.Show("Campos preenchidos incorretamente.",
                    "Cadastro de Matérias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("O nome pode contar apenas letras!",
                "Cadastro de Matérias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
