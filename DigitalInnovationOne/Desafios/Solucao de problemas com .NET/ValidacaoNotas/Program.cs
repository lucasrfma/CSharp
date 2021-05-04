using System;

namespace ValidacaoNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            int continua = 1;
            while ( continua == 1) 
            {
                double nota1 = -1;
                double nota2 = -1;
                double media;
                
                bool sucesso = false;
                while(true)
                {
                    sucesso = double.TryParse(Console.ReadLine(), out nota1);
                    if(!sucesso || nota1 < 0.0 || nota1 > 10.0)
                        Console.WriteLine($"nota invalida");
                    else
                        break;
                }

                sucesso = false;
                while(true)
                {
                    sucesso = double.TryParse(Console.ReadLine(), out nota2);
                    if(!sucesso || nota2 < 0.0 || nota2 > 10.0)
                        Console.WriteLine($"nota invalida");
                    else
                        break;
                }

                media = (nota1 + nota2)/2;
                Console.WriteLine("media = "+media.ToString("n2"));
                
                sucesso = false;
                while( !sucesso || (continua != 1 && continua != 2) )
                {
                    Console.WriteLine($"novo calculo (1-sim 2-nao)");
                    sucesso = int.TryParse(Console.ReadLine(), out continua);
                }
            }
        }
    }
}


