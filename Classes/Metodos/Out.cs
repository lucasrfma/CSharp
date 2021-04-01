namespace Classes.Metodos
{
    public class Out
    {
        static void Dividir(int x, int y, out int resultado, out int resto)
        {
            resultado = x / y;
            resto = x % y;
        }
        static void DividirRef(int x, int y, ref int resultado, ref int resto)
        {
            resultado = x / y;
            resto = x % y;
        }

        public static void Dividir()
        {
            int resultado;
            Dividir(10,3, out resultado, out int resto);
            System.Console.WriteLine("{0} {1}",resultado,resto);
        }
        public static void DividirRef()
        {
            int resultado = 0;
            int resto = 0;
            DividirRef(10,3, ref resultado, ref resto);
            System.Console.WriteLine("{0} {1}",resultado,resto);
        }
    }
}