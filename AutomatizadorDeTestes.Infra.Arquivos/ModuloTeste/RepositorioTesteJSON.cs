using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using AutomatizadorDeTestes.Dominio.ModuloTeste;
using AutomatizadorDeTestes.Infra.Arquivos.Compartilhado;

namespace AutomatizadorDeTestes.Infra.Arquivos.ModuloTeste
{
    public class RepositorioTesteJSON : RepositorioBaseArquivo<Teste>, IRepositorioTeste
    {
        public RepositorioTesteJSON(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Testes.Count > 0)
                contador = dataContext.Testes.Max(x => x.Id);
        }

        public override List<Teste> ObterRegistros()
        {
            return dataContext.Testes;
        }

        public override AbstractValidator<Teste> ObterValidador()
        {
            return new ValidadorTeste();
        }
    }
}
