using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using AutomatizadorDeTestes.Dominio.Compartilhado;


namespace AutomatizadorDeTestes.Infra.Arquivos.Compartilhado
{
    public abstract class RepositorioBaseArquivo<T> where T : EntidadeBase<T>
    {
        protected DataContext dataContext;

        protected int contador = 0;

        public RepositorioBaseArquivo(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public abstract List<T> ObterRegistros();

        public abstract AbstractValidator<T> ObterValidador();

        public virtual ValidationResult Inserir(T novoRegistro)
        {
            var validator = ObterValidador();

            var resultadoValidacao = validator.Validate(novoRegistro);

            if (resultadoValidacao.IsValid)
            {
                novoRegistro.Id = ++contador;

                var registros = ObterRegistros();

                registros.Add(novoRegistro);
            }

            return resultadoValidacao;
        }

        public virtual ValidationResult Editar(T registro)
        {
            var validator = ObterValidador();

            var resultadoValidacao = validator.Validate(registro);

            if (resultadoValidacao.IsValid)
            {
                var registros = ObterRegistros();

                foreach (var item in registros)
                {
                    if (item.Id == registro.Id)
                    {
                        item.Atualizar(registro);
                        break;
                    }
                }
            }

            return resultadoValidacao;
        }

        public virtual ValidationResult Excluir(T registro)
        {
            var resultadoValidacao = new ValidationResult();

            var registros = ObterRegistros();

            if (registros.Remove(registro) == false)
                resultadoValidacao.Errors.Add(new ValidationFailure("", "Não foi possível remover o registro"));

            return resultadoValidacao;
        }

        public virtual List<T> SelecionarTodos()
        {
            return ObterRegistros().ToList();
        }

        public virtual T SelecionarPorId(int id)
        {
            return ObterRegistros()
                .FirstOrDefault(x => x.Id == id);
        }
    
    }
}
