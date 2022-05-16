using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatizadorDeTestes.Dominio.Compartilhado;
using AutomatizadorDeTestes.Dominio.ModuloDisciplina;
using AutomatizadorDeTestes.Dominio.ModuloMateria;
using AutomatizadorDeTestes.Dominio.ModuloQuestao;

namespace AutomatizadorDeTestes.Dominio.ModuloTeste
{
    public class Teste : EntidadeBase<Teste>
    {
        private Teste testeSelecionado;

        public Teste()
        {
            Data = DateTime.Now;
        }

        public int NumeroQuestoes { get; set; }
        public string Titulo { get; set; }
        public Disciplina Disciplina { get; set; }
        public Materia Materia { get; set; }
        public DateTime Data { get; set; }
        public List<Questao> Questoes { get; set; }

        public override void Atualizar(Teste registro)
        {
            NumeroQuestoes = registro.NumeroQuestoes;
            Titulo = registro.Titulo;
            Disciplina = registro.Disciplina;
            Materia = registro.Materia;
            Data = registro.Data;
            Questoes = registro.Questoes;
        }
    }
}
