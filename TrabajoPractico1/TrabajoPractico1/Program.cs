using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TrabajoPractico1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = new Numero();
            //  var c1 = new Calculadora(); NO SE PUEDE X SER STATIC
            //string a =n1.BinarioDecimal("1010001001010");

            double c = 1011;
            string b = n1.DecimalBinario(c);

            //Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
