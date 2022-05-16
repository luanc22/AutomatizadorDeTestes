using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using AutomatizadorDeTestes.Dominio.Compartilhado;

namespace AutomatizadorDeTestes.Dominio.ModuloTeste
{
    public interface IRepositorioTeste : IRepositorioBase<Teste>
    {
        ValidationResult Inserir(Teste teste);
    }
}
