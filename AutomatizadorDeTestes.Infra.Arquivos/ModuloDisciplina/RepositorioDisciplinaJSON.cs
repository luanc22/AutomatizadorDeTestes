using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using AutomatizadorDeTestes.Infra.Arquivos.Compartilhado;
using AutomatizadorDeTestes.Dominio.ModuloDisciplina;

namespace AutomatizadorDeTestes.Infra.Arquivos.ModuloDisciplina
{
    public class RepositorioDisciplinaJSON : RepositorioBaseArquivo<Disciplina>, IRepositorioDisciplina
    {
        public RepositorioDisciplinaJSON(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Disciplinas.Count > 0)
                contador = dataContext.Disciplinas.Max(x => x.Id);
        }

        public override List<Disciplina> ObterRegistros()
        {
            return dataContext.Disciplinas;
        }

        public override AbstractValidator<Disciplina> ObterValidador()
        {
            return new ValidadorDisciplina();
        }
    }
}
