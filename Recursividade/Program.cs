using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valor = 1;
            
            
            Console.WriteLine(CalculadorNumeroFibonacci.CalculaNumeroFibonacci(10));
            Console.WriteLine(CalculaNumeroFibonacciRecursivo(10));
            



            Console.ReadKey();

        }
        
        public static int CalculaNumeroFibonacciRecursivo(int valor)
        {
            int fibonacci;

            if (valor <= 2)
            {
                return 1;
            }
            fibonacci = CalculaNumeroFibonacciRecursivo(valor - 1) + CalculaNumeroFibonacciRecursivo(valor - 2);

            return fibonacci;
        }
        

    }
}
