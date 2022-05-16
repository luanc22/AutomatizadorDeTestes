using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatizadorDeTestes.Dominio.Compartilhado;
using AutomatizadorDeTestes.Dominio.ModuloDisciplina;
using AutomatizadorDeTestes.Dominio.ModuloMateria;

namespace AutomatizadorDeTestes.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        public string Descricao { get; set; }
        public char Resposta { get; set; }
        public Materia Materia { get; set; }

        public Disciplina Disciplina { get; set; }

        public List<string> Alternativas { get; set; }

        public override void Atualizar(Questao registro)
        {
            Descricao = registro.Descricao;
            Disciplina = registro.Disciplina;
            Materia = registro.Materia;
        }

        public override string ToString()
        {
            return $"{Descricao}";
        }
    }
}
