using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatizadorDeTestes.WinAppForm.Compartilhado;   

namespace AutomatizadorDeTestes.WinAppForm.ModuloTeste
{
    public class ConfiguracaoToolBoxTeste : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Controle de Testes";

        public override string TooltipInserir => "Gerar um teste.";

        public override string TooltipExcluir => "Excluir um teste existente";

        public override string TooltipEditar => "Você não pode editar um teste";

        public override string TooltipGerarPdf => "Gerar PDF de um teste";

        public override string TooltipDuplicar => "Duplicar um teste";

        public override bool GerarPdfHabilitado { get { return true; } }

        public override bool DuplicarHabilitado { get { return true; } }

        public override bool EditarHabilitado { get { return false; } }

    }
}
