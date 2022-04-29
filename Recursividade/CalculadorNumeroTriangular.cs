using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class CalculadorNumeroTriangular
    {
        public static int CalculaNumeroTriangular(int valor)
        {
            int numeroTriangulo = 0;
            for (int i = valor; i > 0; i--)
            {
                numeroTriangulo += i;
            }

            return numeroTriangulo;
        }

        public static int CalculaNumeroTriangularRecursivo(int valor)
        {
            int numeroTriangulo;
            if (valor == 1)
            {
                return 1;
            }

            numeroTriangulo = valor + CalculaNumeroTriangularRecursivo(valor - 1);

            return numeroTriangulo;
        }

    }
}
