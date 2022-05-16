using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomatizadorDeTestes.Dominio.ModuloMateria;
using AutomatizadorDeTestes.WinAppForm.Compartilhado;

namespace AutomatizadorDeTestes.WinAppForm.ModuloMateria
{
    public partial class TabelaControlMateria : UserControl
    {
        public TabelaControlMateria()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Serie", HeaderText = "Série"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina"},
            };

            return colunas;
        }

        public int ObtemNumeroMateriaSelecionada()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Materia> materias)
        {
            grid.DataSource = materias;
        }
    }
}
