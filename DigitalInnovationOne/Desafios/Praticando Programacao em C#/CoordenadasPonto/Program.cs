// ler 2 valores com uma casa decimal x e y - coordenadas de um ponto
// Determinar onde está:
//  - Quadrante 1 a 4 (1 : x e y > 0)               "Q1" "Q2" ...
//    Q2 em diante sentido antihorário a partir do Q1   
//  - Em cima de um eixo único                      "Eixo X" / "Eixo Y
//  - Na origem (0,0)   	                        "Origem"

//EX:
//entrada   saida
//4.5 -2.2  Q4
//0.1 0.1   Q1
//0.0 0.0   Origem
using System;

namespace CoordenadasPonto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split();
            float x = float.Parse(entrada[0]);
            float y = float.Parse(entrada[1]);

            if(x>0)
            {
                if(y>0)
                {
                    Console.WriteLine($"Q1");
                }
                else if (y<0)
                {
                    Console.WriteLine($"Q4");
                }
                else
                {
                    Console.WriteLine($"Eixo X");
                }
            }
            else if (x < 0)
            {
                if(y>0)
                {
                    Console.WriteLine($"Q2");
                }
                else if (y<0)
                {
                    Console.WriteLine($"Q3");
                }
                else
                {
                    Console.WriteLine($"Eixo X");
                }
            }
            else
            {
                if( y == 0)
                {
                    Console.WriteLine($"Origem");
                }
                else
                {
                    Console.WriteLine($"Eixo Y");
                }   
            }
            Console.ReadKey();
        }
    }
}
