using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using AutomatizadorDeTestes.Dominio.Compartilhado;

namespace AutomatizadorDeTestes.Dominio.ModuloMateria
{
    public interface IRepositorioMateria : IRepositorioBase<Materia>
    {
        ValidationResult Inserir(Materia materia);

        ValidationResult Editar(Materia materia);
    }
}
