using System;
using System.Collections.Generic;

namespace Supermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
            for(int i = 0; i < totalDeCasosDeTeste; ++i)
            {
                string entrada = Console.ReadLine().ToLower();
                string[] lista = entrada.Split();
                
                SortedSet<string> listaReduzida = new SortedSet<string>(lista);
                foreach (var item in listaReduzida)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
