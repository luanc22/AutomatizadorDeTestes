using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace AutomatizadorDeTestes.Dominio.ModuloMateria
{
    public class ValidadorMateria : AbstractValidator<Materia> 
    {
        public ValidadorMateria()
        {
            RuleFor(x => x.Nome)
               .NotNull().NotEmpty().MinimumLength(4);

            RuleFor(x => x.Disciplina)
                .NotNull().NotEmpty();

            RuleFor(x => x.Serie)
                .NotNull().NotEmpty();
        }
    }
}
