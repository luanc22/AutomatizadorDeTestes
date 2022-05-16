using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizadorDeTestes.Dominio.Compartilhado
{
    public abstract class EntidadeBase<T>
    {
        public int Id { get; set; }

        public abstract void Atualizar(T registro);
    }
}
