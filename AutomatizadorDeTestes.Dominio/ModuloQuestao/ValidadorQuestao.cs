using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace AutomatizadorDeTestes.Dominio.ModuloQuestao
{
    public class ValidadorQuestao : AbstractValidator<Questao>
    {
        public ValidadorQuestao()
        {
            RuleFor(x => x.Descricao)
               .NotNull().NotEmpty().MinimumLength(10);

            RuleFor(x => x.Disciplina)
                .NotNull().NotEmpty();

            RuleFor(x => x.Materia)
                .NotNull().NotEmpty();
        }
    }
}
