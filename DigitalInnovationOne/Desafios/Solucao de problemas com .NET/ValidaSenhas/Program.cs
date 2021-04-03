using System;

namespace ValidaSenhas
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            while( (entrada = Console.ReadLine()) != null )
            {
                // // no mínimo uma letra maíuscula e uma minúscula
                // if( (entrada.ToUpper() != entrada) &&
                //     (entrada.ToLower() != entrada) &&
                // // no mínimo um número
                //     (entrada.Contains()) && )

                // 3 criterios:
                //      tamanho 6 <= t <= 32
                //      Presença de letra M, letra m, dígito
                //      tiposProibidos = não pode haver outros tipos de caracteres
                bool tamanho = (entrada.Length >= 6) && (entrada.Length <= 32);
                bool letra_M = false;
                bool letra_m = false;
                bool digito = false;
                bool tiposProibidos = false;
                for(int i = 0; (i < entrada.Length) && tamanho; ++i)
                {
                    if( entrada[i] >= 'a' && entrada[i] <= 'z' )
                    {
                        letra_m = true;
                    }
                    else if( entrada[i] >= 'A' && entrada[i] <= 'Z' )
                    {
                        letra_M = true;
                    }
                    else if( entrada[i] >= '0' && entrada[i] <= '9' )
                    {
                        digito = true;
                    }
                    else
                    {
                        // não é nenhum dos tipos permitidos, então é um tipo proibido
                        tiposProibidos = true;
                        break;
                    }
                }
                if( tamanho && letra_M && letra_m && digito && !tiposProibidos )
                {
                    Console.WriteLine($"Senha valida.");
                }
                else
                {
                    Console.WriteLine($"Senha invalida.");
                }
            }
            Console.ReadKey();
        }
    }
}
