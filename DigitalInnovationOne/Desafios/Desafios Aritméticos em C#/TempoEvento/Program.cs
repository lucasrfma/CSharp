using System;

namespace TempoEvento
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaInicio,  horaMomentoInicio,  minutoMomentoInicio,  segundoMomentoInicio;
            int diaTermino, horaMomentoTermino, minutoMomentoTermino, segundoMomentoTermino;
            
            // Primeira linha: Dia dataInicio
            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            // Segunda linha: hh : mm : ss
            string[] dadosMomentoInicio = Console.ReadLine().Split(" : ");
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[1]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);


            // Primeira linha: Dia dataTermino
            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            // Segunda linha: hh : mm : ss
            string[] dadosMomentoTermino = Console.ReadLine().Split(" : ");
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[1]);
            segundoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[2]);
           

            int transformaSegundosInicio = diaInicio*24*3600 + horaMomentoInicio*3600 + minutoMomentoInicio*60 + segundoMomentoInicio;
            int transformaSegundosTermino = diaTermino*24*3600 + horaMomentoTermino*3600 + minutoMomentoTermino*60 + segundoMomentoTermino;

            int diferencaSegundos = transformaSegundosTermino - transformaSegundosInicio;
            int W =  diferencaSegundos/(24*3600);
            diferencaSegundos =  diferencaSegundos%(24*3600);
            int X =  diferencaSegundos/(3600);
            diferencaSegundos =  diferencaSegundos%(3600);
            int Y =  diferencaSegundos/(60);
            int Z = diferencaSegundos%60;

            Console.WriteLine("{0} dia(s)", W);
            Console.WriteLine("{0} hora(s)", X);
            Console.WriteLine("{0} minuto(s)", Y);
            Console.WriteLine("{0} segundo(s)", Z);

            Console.ReadKey();
        }
    }
}
