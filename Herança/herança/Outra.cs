namespace Herança.herança
{
    public class Outra : Ponto
    {
        public int z;

        public Ponto3D(int a ,int b ,int c ) : base(x, y)
        {
            this.z = z;
            Calcular();
        }

        public static void Calcular4()
        {
            //fac algo
        }
        public override void Calcular4()
        {
            base.Calcular3();
        }
    }
}