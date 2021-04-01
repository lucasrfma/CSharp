using System;

namespace startingOut
{
    public class Pilha
    {
        Posicao primeiro;
        public void empilhar(object item)
        {
            primeiro = new Posicao(primeiro, item);
        }
        public object desempilhar()
        {
            if(primeiro == null)
            {
                throw new InvalidOperationException("Tentativa de desempilhar uma pilha vazia.");
            }
            
            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }
        class Posicao
        {
            public object item;
            public Posicao proximo;
            public Posicao(Posicao proximo, object item)
            {
                this.item = item;
                this.proximo = proximo;
            }
        }
    }
}