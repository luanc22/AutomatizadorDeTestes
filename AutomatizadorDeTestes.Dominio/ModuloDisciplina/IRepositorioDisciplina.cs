using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatizadorDeTestes.Dominio.Compartilhado;
using FluentValidation.Results;

namespace AutomatizadorDeTestes.Dominio.ModuloDisciplina
{
    public interface IRepositorioDisciplina : IRepositorioBase<Disciplina>
    {
        ValidationResult Inserir(Disciplina disciplina);

        ValidationResult Editar(Disciplina disciplina);
    }
}
