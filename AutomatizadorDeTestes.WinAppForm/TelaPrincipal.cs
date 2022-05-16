using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomatizadorDeTestes.WinAppForm.Compartilhado;
using AutomatizadorDeTestes.WinAppForm.ModuloDisciplina;
using AutomatizadorDeTestes.WinAppForm.ModuloMateria;
using AutomatizadorDeTestes.WinAppForm.ModuloQuestao;
using AutomatizadorDeTestes.WinAppForm.ModuloTeste;
using AutomatizadorDeTestes.Infra.Arquivos.Compartilhado;
using AutomatizadorDeTestes.Infra.Arquivos.Compartilhado.Serializadores;
using AutomatizadorDeTestes.Infra.Arquivos.ModuloDisciplina;
using AutomatizadorDeTestes.Infra.Arquivos.ModuloMateria;
using AutomatizadorDeTestes.Infra.Arquivos.ModuloQuestao;
using AutomatizadorDeTestes.Infra.Arquivos.ModuloTeste;

namespace AutomatizadorDeTestes.WinAppForm
{
    public partial class TelaPrincipal : Form
    {
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;
        private DataContext contextoDados;

        public TelaPrincipal(DataContext contextoDados)
        {
            InitializeComponent();

            Instancia = this;

            tlStsLblMensagem.Text = string.Empty;
            tlSpLblCadastro.Text = string.Empty;

            this.contextoDados = contextoDados;

            InicializarControladores();
        }

        public static TelaPrincipal Instancia
        {
            get;
            private set;
        }

        public void AtualizarRodape(string mensagem)
        {
            tlStsLblMensagem.Text = mensagem;
        }

        private void InicializarControladores()
        {
            var repositorioDisciplina = new RepositorioDisciplinaJSON(contextoDados);
            var repositorioMateria = new RepositorioMateriaJSON(contextoDados);
            var repositorioQuestao = new RepositorioQuestaoJSON(contextoDados);
            var repositorioTeste = new RepositorioTesteJSON(contextoDados);

            controladores = new Dictionary<string, ControladorBase>();

            controladores.Add("Disciplinas", new ControladorDisciplina(repositorioDisciplina));
            controladores.Add("Matérias", new ControladorMateria(repositorioMateria, repositorioDisciplina));
            controladores.Add("Questões", new ControladorQuestao(repositorioQuestao, repositorioMateria, repositorioDisciplina));
            controladores.Add("Testes", new ControladorTeste(repositorioTeste, repositorioQuestao, repositorioMateria, repositorioDisciplina));
        }

        private void ConfigurarTelaPrincipal(ToolStripMenuItem opcaoSelecionada)
        {
            var tipo = opcaoSelecionada.Text;

            controlador = controladores[tipo];

            ConfigurarToolbox();

            ConfigurarListagem();
        }

        private void ConfigurarToolbox()
        {
            ConfiguracaoToolBoxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null)
            {
                tlSpBotoes.Enabled = true;

                tlSpLblCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }

        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObtemListagem();

            plRegistros.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            plRegistros.Controls.Add(listagemControl);
        }

        private void ConfigurarBotoes(ConfiguracaoToolBoxBase configuracao)
        {
            tlspBtnAdicionar.Enabled = configuracao.InserirHabilitado;
            tlspBtnEditar.Enabled = configuracao.EditarHabilitado;
            tlspBtnExcluir.Enabled = configuracao.ExcluirHabilitado;
            tlspBtnPDF.Enabled = configuracao.GerarPdfHabilitado;
            btnDuplicar.Enabled = configuracao.DuplicarHabilitado;
        }

        private void ConfigurarTooltips(ConfiguracaoToolBoxBase configuracao)
        {
            tlspBtnAdicionar.ToolTipText = configuracao.TooltipInserir;
            tlspBtnEditar.ToolTipText = configuracao.TooltipEditar;
            tlspBtnExcluir.ToolTipText = configuracao.TooltipExcluir;
            tlspBtnPDF.ToolTipText = configuracao.TooltipGerarPdf;
            btnDuplicar.ToolTipText = configuracao.TooltipDuplicar;
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void matériasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void questõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void testesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void tlspBtnAdicionar_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            { 
                return;
            }
            controlador.Inserir();
        }

        private void tlspBtnEditar_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                return;
            }
            controlador.Editar();
        }

        private void tlspBtnExcluir_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                return;
            }
            controlador.Excluir();
        }

        private void tlspBtnPDF_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                return;
            }
            ((ControladorTeste)controlador).GerarPdf();
        }

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                return;
            }
            ((ControladorTeste)controlador).Duplicar();
        }
    }
}
