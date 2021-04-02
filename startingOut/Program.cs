using System;

namespace startingOut
{
    class Program
    {
        static void Main(string[] args)
        {
            var pilha = new Pilha();
 
            pilha.empilhar(1);
            pilha.empilhar(10);
            pilha.empilhar(100);
            try
            {
            Console.WriteLine(pilha.desempilhar());
            Console.WriteLine(pilha.desempilhar());
            Console.WriteLine(pilha.desempilhar());
            // testando a exceção preparada
            Console.WriteLine(pilha.desempilhar());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
