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
using AutomatizadorDeTestes.WinAppForm.Compartilhado;

namespace AutomatizadorDeTestes.WinAppForm.ModuloDisciplina
{
    public partial class TelaCadastroDisciplina : Form
    {
        private Disciplina disciplina;
        ValidadorRegex validador = new ValidadorRegex();

        public TelaCadastroDisciplina()
        {
            InitializeComponent();
            txtNumDisci.Text = "";
        }

        public Func<Disciplina, ValidationResult> GravarRegistro { get; set; }

        public Disciplina Disciplina
        {
            get { return disciplina; }
            set
            {
                disciplina = value;

                txtNumDisci.Text = disciplina.Id.ToString();

                txtNomeDisci.Text = disciplina.Nome;
            }
        }

        private void TelaCadastroDisciplina_Load(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroDisciplina_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipal.Instancia.AtualizarRodape("");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (validador.Letras(txtNomeDisci.Text))
            {
                disciplina.Id = int.Parse(txtNumDisci.Text);
                disciplina.Nome = txtNomeDisci.Text;

                
                var resultadoValidacao = GravarRegistro(disciplina);

                if (resultadoValidacao.IsValid == false)
                {
                    string erro = resultadoValidacao.Errors[0].ErrorMessage;

                    TelaPrincipal.Instancia.AtualizarRodape(erro);

                    DialogResult = DialogResult.None;

                    MessageBox.Show("Campos preenchidos incorretamente.",
                    "Cadastro de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("O nome pode contar apenas letras!",
                "Cadastro de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
