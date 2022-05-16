using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace AutomatizadorDeTestes.Dominio.ModuloDisciplina
{
    public class ValidadorDisciplina : AbstractValidator<Disciplina>
    {
        public ValidadorDisciplina()
        {
            RuleFor(x => x.Nome)
                .NotNull().NotEmpty().MinimumLength(4);
        }
    }
}