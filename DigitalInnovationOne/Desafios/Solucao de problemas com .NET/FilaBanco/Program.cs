using System;

namespace FilaBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            int testes = int.Parse(Console.ReadLine());

            for(int i = 0; i < testes; ++i )
            {
                int clientes = int.Parse(Console.ReadLine());

                string[] entrada = Console.ReadLine().Split();
                int[] novaOrdem = new int[entrada.Length];
                
                int naoTroca = entrada.Length;
                
                // preenche array de ints com as senhas da fila
                for (int j = 0; j < entrada.Length; j++)
                {
                    novaOrdem[j] = int.Parse(entrada[j]);
                }
                
                // verifica se cada cliente mudou de posição
                // se tiver mudado, decrementa a contagem de clientes que não trocaram de lugar
                for (int j = 0; j < novaOrdem.Length; j++)
                {
                    int posicao = 0;
                    
                    for (int k = 0; k < novaOrdem.Length ; k++)
                        if( novaOrdem[j] < novaOrdem[k] )
                            ++posicao;
                    
                    if( posicao != j )
                        --naoTroca;
                }

                Console.WriteLine(naoTroca);
            }
            Console.ReadKey();
        }
    }
}
