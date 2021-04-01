using System;
using Classes.Herança;
using Classes.Metodos;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto ponto = new Ponto(3,4);
            Ponto3D ponto3d = new Ponto3D(3,4,5);
            Ponto ponto3dfajuto = new Ponto3D(3,4,5);

            ponto.CalcularDistancia3();
            ponto3d.CalcularDistancia3();
            ponto3dfajuto.CalcularDistancia3();

            Console.WriteLine(ponto);
            Console.WriteLine(ponto3d);
            Console.WriteLine(ponto3dfajuto);
            
            Ref.Inverter();
            Out.Dividir();
            Out.DividirRef();
        }
    }
}
