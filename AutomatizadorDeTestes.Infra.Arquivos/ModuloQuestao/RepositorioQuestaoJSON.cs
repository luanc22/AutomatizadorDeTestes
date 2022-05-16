using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using AutomatizadorDeTestes.Dominio.ModuloQuestao;
using AutomatizadorDeTestes.Infra.Arquivos.Compartilhado;

namespace AutomatizadorDeTestes.Infra.Arquivos.ModuloQuestao
{
    public class RepositorioQuestaoJSON : RepositorioBaseArquivo<Questao>, IRepositorioQuestao
    {
        public RepositorioQuestaoJSON(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Questoes.Count > 0)
                contador = dataContext.Questoes.Max(x => x.Id);
        }

        public override List<Questao> ObterRegistros()
        {
            return dataContext.Questoes;
        }

        public override AbstractValidator<Questao> ObterValidador()
        {
            return new ValidadorQuestao();
        }

        public List<Questao> SelecionarQuestoesPorDisciplina(string nomeDisciplina)
        {
            return ObterRegistros()
                .Where(x => x.Disciplina.Nome == nomeDisciplina)
                .ToList();
        }

        public List<Questao> SelecionarQuestoesPorMateria(string nomeMateria)
        {
            return ObterRegistros()
                .Where(x => x.Materia.Nome == nomeMateria)
                .ToList();
        }
    }
}
