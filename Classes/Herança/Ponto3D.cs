namespace Classes.Herança
{
    public class Ponto3D : Ponto
    {
        // atributos
        public int z;

        // métodos
        public Ponto3D(int x, int y, int z): base(x,y)
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular()
        {

        }
        public  void CalcPub()
        { 

        }
        public override void CalcularDistancia3()
        {
            System.Console.WriteLine("Ponto3d");
        }
    }
}