using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region atributos
        private double numero;
        #endregion

        #region constructores
        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.numero = ValidarNumero(strNumero); ///ESTO  NO LO PUEDO HACER
        }
        #endregion

        private double ValidarNumero(string strNumero)
        {
            double retorno;
            bool resultadoParseo = double.TryParse(strNumero, out retorno);
            if (resultadoParseo == false)
            {
                retorno = 0;
            }
            return retorno;
        }

        ///FALTA ESE SET NUMERO
        ///

        public string BinarioDecimal(string binario)
        {
            char[] array = binario.ToCharArray();
            Array.Reverse(array);

            double resultado = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    resultado +=  Math.Pow(2, i);
                }
            }
            
            return resultado.ToString(); 
        }


        public string DecimalBinario(double numero)
        {
            double numeroRestante=3;
            double resto=0;
            string binario = "";
          

            while (numeroRestante >= 1) 
            {
                resto = numero % 2;
                numeroRestante = numero / 2;

                Console.WriteLine("s");
                binario = resto.ToString() + binario;
            } 

            return binario;
        }


    }
}
