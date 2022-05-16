using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomatizadorDeTestes.Dominio.ModuloDisciplina;
using AutomatizadorDeTestes.Dominio.ModuloMateria;
using AutomatizadorDeTestes.Dominio.ModuloQuestao;
using AutomatizadorDeTestes.WinAppForm.Compartilhado;

namespace AutomatizadorDeTestes.WinAppForm.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private readonly IRepositorioQuestao repositorioQuestao;
        private readonly IRepositorioMateria repositorioMateria;
        private readonly IRepositorioDisciplina repositorioDisciplina;

        private TabelaControlQuestao tabelaQuestoes;
        public ControladorQuestao(IRepositorioQuestao repositorioQuestao, IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override void Inserir()
        {
            var disciplinas = repositorioDisciplina.SelecionarTodos();
            var materias = repositorioMateria.SelecionarTodos();

            TelaCadastroQuestao tela = new TelaCadastroQuestao(disciplinas, materias);
            tela.Questao = new Questao();

            tela.GravarRegistro = repositorioQuestao.Inserir;

            DialogResult resultado = tela.ShowDialog();

            CarregarQuestoes();
        }

        public override void Excluir()
        {
            Questao questaoSelecionada = ObtemQuestaoSelecionada();

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Selecione uma questão, por favor.",
                "Exclusão de Questões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja excluir a questão?",
                "Exclusão de Questões", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioQuestao.Excluir(questaoSelecionada);
                CarregarQuestoes();
            }
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaQuestoes == null)
                tabelaQuestoes = new TabelaControlQuestao();

            CarregarQuestoes();

            return tabelaQuestoes;
        }

        public override ConfiguracaoToolBoxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolBoxQuestao();
        }


        private Questao ObtemQuestaoSelecionada()
        {
            var Id = tabelaQuestoes.ObtemNumeroQuestaoSelecionada();

            return repositorioQuestao.SelecionarPorId(Id);
        }

        private void CarregarQuestoes()
        {
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            tabelaQuestoes.AtualizarRegistros(questoes);

            TelaPrincipal.Instancia.AtualizarRodape($"Visualizando {questoes.Count} questões.");
        }
    }
}
