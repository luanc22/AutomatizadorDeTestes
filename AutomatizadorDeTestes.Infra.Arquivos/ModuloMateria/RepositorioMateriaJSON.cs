using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using AutomatizadorDeTestes.Dominio.ModuloMateria;
using AutomatizadorDeTestes.Infra.Arquivos.Compartilhado;


namespace AutomatizadorDeTestes.Infra.Arquivos.ModuloMateria
{
    public class RepositorioMateriaJSON : RepositorioBaseArquivo<Materia>, IRepositorioMateria
    {
        public RepositorioMateriaJSON(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Materias.Count > 0)
                contador = dataContext.Materias.Max(x => x.Id);
        }

        public override List<Materia> ObterRegistros()
        {
            return dataContext.Materias;
        }

        public override AbstractValidator<Materia> ObterValidador()
        {
            return new ValidadorMateria();
        }
    }
}
