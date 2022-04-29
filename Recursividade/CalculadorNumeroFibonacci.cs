using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class CalculadorNumeroFibonacci
    {
        public static int CalculaNumeroFibonacci(int valor)
        {
            int a = 1, b = 1, i, c;

            if (valor == 1 || valor == 2)
            {
                return 1;
            }

            for (i = 2; i < valor; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
    }
}
