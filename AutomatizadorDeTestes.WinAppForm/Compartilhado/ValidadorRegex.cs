using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizadorDeTestes.WinAppForm.Compartilhado
{
    public class ValidadorRegex
    {
        public bool Numeros(string numero)
        {
            bool valido = System.Text.RegularExpressions.Regex.IsMatch(numero, @"^[0-9]*$");

            return valido;
        }

        public bool Letras(string letra)
        {
            bool valido = System.Text.RegularExpressions.Regex.IsMatch(letra, @"^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]*$");

            return valido;
        }
    }
}
