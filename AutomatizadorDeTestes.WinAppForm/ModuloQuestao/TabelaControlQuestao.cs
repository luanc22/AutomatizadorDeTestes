using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomatizadorDeTestes.Dominio.ModuloQuestao;
using AutomatizadorDeTestes.WinAppForm.Compartilhado;

namespace AutomatizadorDeTestes.WinAppForm
{
    public partial class TabelaControlQuestao : UserControl
    {
        public TabelaControlQuestao()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Número"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Descricao", HeaderText = "Descricao"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Materia"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Resposta", HeaderText = "Resposta"},
            };

            return colunas;
        }

        public int ObtemNumeroQuestaoSelecionada()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Questao> questoes)
        {
            grid.DataSource = questoes;
        }
    }
}
