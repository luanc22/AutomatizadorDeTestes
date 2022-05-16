using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace AutomatizadorDeTestes.Dominio.ModuloTeste
{
    public class ValidadorTeste : AbstractValidator<Teste>
    {
        public ValidadorTeste()
        {
            RuleFor(x => x.Titulo)
               .NotNull().NotEmpty().MinimumLength(4);

            RuleFor(x => x.Disciplina)
                .NotNull().NotEmpty();

            RuleFor(x => x.Materia)
                .NotNull().NotEmpty();

            RuleFor(x => (int)x.NumeroQuestoes)
                .NotNull().NotEmpty().GreaterThan(4);
        }
    }
}
