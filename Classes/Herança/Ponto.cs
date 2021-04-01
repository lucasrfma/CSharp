namespace Classes.Herança
{
    public class Ponto
    {
        // atributos
        public int x,y;
        private double _distancia;

        // métodos
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia()
        {
            
        }
        public void CalcularDistancia2()
        {

        }
        public virtual void CalcularDistancia3()
        {
            System.Console.WriteLine("Ponto");
        }

    }
}