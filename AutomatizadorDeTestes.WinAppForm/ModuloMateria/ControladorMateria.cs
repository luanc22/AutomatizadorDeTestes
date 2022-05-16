using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using System.Windows.Forms;
using AutomatizadorDeTestes.Dominio.ModuloMateria;
using AutomatizadorDeTestes.Dominio.ModuloDisciplina;
using AutomatizadorDeTestes.WinAppForm.Compartilhado;

namespace AutomatizadorDeTestes.WinAppForm.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private readonly IRepositorioMateria repositorioMateria;
        private readonly IRepositorioDisciplina repositorioDisciplina;

        private TabelaControlMateria tabelaMaterias;
        public ControladorMateria(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override void Inserir()
        {
            var disciplinas = repositorioDisciplina.SelecionarTodos();

            TelaCadastroMateria tela = new TelaCadastroMateria(disciplinas);
            tela.Materia = new Materia();

            tela.GravarRegistro = repositorioMateria.Inserir;

            DialogResult resultado = tela.ShowDialog();

            CarregarMaterias();
        }

        public override void Editar()
        {
            Materia materiaSelecionada = ObtemMateriaSelecionada();

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Selecione uma matéria primeiro",
                "Edição de Matérias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var disciplinas = repositorioDisciplina.SelecionarTodos();

            TelaCadastroMateria tela = new TelaCadastroMateria(disciplinas);

            tela.Materia = materiaSelecionada;

            tela.GravarRegistro = repositorioMateria.Editar;

            CarregarMaterias();
        }

        public override void Excluir()
        {
            Materia materiaSelecionada = ObtemMateriaSelecionada();

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Selecione uma matéria primeiro",
                "Exclusão de Matérias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a matéria?",
                "Exclusão de Matérias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioMateria.Excluir(materiaSelecionada);
                CarregarMaterias();
            }
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaMaterias == null)
                tabelaMaterias = new TabelaControlMateria();

            CarregarMaterias();

            return tabelaMaterias;
        }

        public override ConfiguracaoToolBoxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolBoxMateria();
        }


        private Materia ObtemMateriaSelecionada()
        {
            var id = tabelaMaterias.ObtemNumeroMateriaSelecionada();

            return repositorioMateria.SelecionarPorId(id);
        }

        private void CarregarMaterias()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            tabelaMaterias.AtualizarRegistros(materias);

            TelaPrincipal.Instancia.AtualizarRodape($"Visualizando {materias.Count} matérias.");
        }
    }
}
