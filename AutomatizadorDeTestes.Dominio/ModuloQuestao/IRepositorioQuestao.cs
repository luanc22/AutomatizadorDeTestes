using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using AutomatizadorDeTestes.Dominio.Compartilhado;

namespace AutomatizadorDeTestes.Dominio.ModuloQuestao
{
    public interface IRepositorioQuestao : IRepositorioBase<Questao>
    {
        ValidationResult Inserir(Questao questao);

        List<Questao> SelecionarQuestoesPorMateria(string nomeMateria);

        List<Questao> SelecionarQuestoesPorDisciplina(string nomeDisciplina);
    }
}
