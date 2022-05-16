using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatizadorDeTestes.Dominio.Compartilhado;

namespace AutomatizadorDeTestes.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {

        public Disciplina() {}

        public string Nome { get; set; }

        public override void Atualizar(Disciplina registro)
        {
            Nome = registro.Nome;
        }
    }
}
