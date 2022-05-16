using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using AutomatizadorDeTestes.Dominio.ModuloDisciplina;
using AutomatizadorDeTestes.WinAppForm.Compartilhado;

namespace AutomatizadorDeTestes.WinAppForm.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private readonly IRepositorioDisciplina repositorioDisciplina;

        private TabelaControlDisciplina tabelaDisciplinas;
        public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override void Inserir()
        {
            TelaCadastroDisciplina tela = new TelaCadastroDisciplina();
            tela.Disciplina = new Disciplina();

            tela.GravarRegistro = repositorioDisciplina.Inserir;

            DialogResult resultado = tela.ShowDialog();

            CarregarDisciplinas();
        }

        public override void Editar()
        {
            Disciplina disciplinaSelecionada = ObtemDisciplinaSelecionada();

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro.",
                "Edição de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroDisciplina tela = new TelaCadastroDisciplina();

            tela.Disciplina = disciplinaSelecionada;

            tela.GravarRegistro = repositorioDisciplina.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarDisciplinas();
            }
        }

        public override void Excluir()
        {
            Disciplina disciplinaSelecionada = ObtemDisciplinaSelecionada();

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro",
                "Exclusão de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a disciplina?",
                "Exclusão de Disciplinas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioDisciplina.Excluir(disciplinaSelecionada);
                CarregarDisciplinas();
            }
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaDisciplinas == null)
                tabelaDisciplinas = new TabelaControlDisciplina();

            CarregarDisciplinas();

            return tabelaDisciplinas;
        }

        public override ConfiguracaoToolBoxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolBoxDisciplina();
        }


        private Disciplina ObtemDisciplinaSelecionada()
        {
            var id = tabelaDisciplinas.ObtemNumeroDisciplinaSelecionada();

            return repositorioDisciplina.SelecionarPorId(id);
        }

        private void CarregarDisciplinas()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos(); 

            tabelaDisciplinas.AtualizarRegistros(disciplinas);

            TelaPrincipal.Instancia.AtualizarRodape($"Visualizando {disciplinas.Count} disciplinas.");
        }
    }
}
