using System;

namespace _02_Instrucoes
{
    class Program
    {
        static void declaracoes()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a+b+c+d);
        }
        static void instrucaoIf(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("Um argumento");
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos");
            }
        }
        static void instrucaoSwitch(string[] args)
        {
            switch (args.Length)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento"); break;
                case 1:
                    Console.WriteLine("Um argumento"); break;
                default:
                    Console.WriteLine($"{args.Length} argumento"); break;
            }
        }
        static void instrucaoWhile(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                ++i;
            }
        }
        static void instrucaoFor(string[] args)
        {
            for(int i = 0; i < args.Length; ++i)
            {
                Console.WriteLine(args[i]);
            }
        }
        static void instrucaoForEach(string[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
        }
        static void instrucaoForVsForEach()
        {
            string[] words = new string[3];
            words[0] = "primeira";
            words[1] = "segunda";
            words[2] = "terceira";
            foreach (var word in words)
            {
                // Doesn't work!!
                // word = word.ToUpper();
                Console.WriteLine(word);
            }
            for (int i = 0; i < words.Length; ++i)
            {
                words[i] = words[i].ToUpperInvariant();
                Console.WriteLine(words[i]);
            }
        }
        static void instrucaoDoWhile()
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            } while (!string.IsNullOrEmpty(texto));
        }
        static void instrucaoDoWhileNoBlank()
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            } while (!string.IsNullOrWhiteSpace(texto));
        }
        static void instrucaoTryCatchFinallyThrow(string[] args)
        {
            double Dividir( double x, double y)
            {
                if(y==0){
                    throw new DivideByZeroException();
                }
                return x/y;
            }

            try
            {
                if(args.Length != 2)
                {
                    throw new InvalidOperationException("Informe 2 números");
                }
                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x,y));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro genérico: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Até breve!");
            }
        }
        static void instrucaoUsing(string[] args)
        {
            using ( System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }
        static void Main()
        {
            declaracoes();
            string[] args = new string[3] {"s1","s2","s3"};

            instrucaoIf(args);
            instrucaoSwitch(args);
            instrucaoWhile(args);
            instrucaoFor(args);
            instrucaoForEach(args);
            instrucaoForVsForEach();
            instrucaoDoWhile();
            instrucaoDoWhileNoBlank();
            instrucaoTryCatchFinallyThrow(args);
            instrucaoUsing(args);
        }
    }
}
