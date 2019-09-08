using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            string retorno = "+";

            if(operador == "-" || operador == "*" || operador == "/")
            {
                retorno = operador;
            }
            return retorno;
        }

        /*private double Operar(Numero num1, Numero num2, string operador)
        {

        }*/

    }
}
