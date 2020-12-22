namespace Herança.herança
{
    public class Ponto
    {
        public int x, y; //posso ter acesso em qualquer lugar
        private int _distancia;//posso ter acesso apenas aqui
        public Ponto(int a, int b)
        {
            this.x = a;
            this.y = b;
        }

        protected void  Calcular()
        {
            Calcular2();
        }
        private void  Calcular2()
        {
            //Faz algo
        }
        public virtual void Calcular3()//faz com que a classe filha sobrescreva
        {
            //Faz algo
        }
    }
}