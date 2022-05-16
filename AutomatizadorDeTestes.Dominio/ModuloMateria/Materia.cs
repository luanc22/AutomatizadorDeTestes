using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatizadorDeTestes.Dominio.Compartilhado;
using AutomatizadorDeTestes.Dominio.ModuloDisciplina;

namespace AutomatizadorDeTestes.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public string Nome { get; set; }

        public string Serie { get; set; }

        public Disciplina Disciplina { get; set; }

        public override void Atualizar(Materia registro)
        {
            Nome = registro.Nome;
            Serie = registro.Serie;
            Disciplina = registro.Disciplina;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
