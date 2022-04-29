using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    public static class CalculadorFatorial
    {
        public static int CalculaFatorial(int fatorando)
        {
            int i, fatorial;
            fatorial = 1;
            for (i = 1; i <= fatorando; i++)
            {
                fatorial = fatorial * i;
            }
            return fatorial;
        }

        public static int CalculaFatorialRecursivo(int fatorando)
        {
            int fatorial;
            if (fatorando == 1 || fatorando == 0)
            {
                return 1;
            }
            fatorial = fatorando * CalculaFatorialRecursivo(fatorando - 1);
            return fatorial;
        }


    }
}
