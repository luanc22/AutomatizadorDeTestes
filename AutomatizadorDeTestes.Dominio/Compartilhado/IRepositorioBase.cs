using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace AutomatizadorDeTestes.Dominio.Compartilhado
{
    public interface IRepositorioBase<T> where T : EntidadeBase<T>
    {
        ValidationResult Excluir(T registro);

        List<T> SelecionarTodos();

        T SelecionarPorId(int id);
    }
}
