using System;

namespace InverterDigitos
{
    class Program
    {
        static void Main(string[] args)
        {

            string numero = Console.ReadLine();
            char[] inversor = numero.ToCharArray();
            for(int i = 0; i <= numero.Length/2; ++i)
            {
                inversor[numero.Length-1-i] = numero[i];
                inversor[i] = numero[numero.Length-1-i];
            }
            numero = new string(inversor);

            Console.WriteLine(numero);
            Console.ReadKey();

        }
    }
}
