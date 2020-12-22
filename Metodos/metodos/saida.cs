namespace Metodos.metodos
{
    public class saida
    {
        static void Dividir(int x , int y, out int resultado, out int resto)
        {
            resultado = x / y;
            resto = x / y;
        }

        public static void Dividir()
        {
            Dividir(10,3, out int resultado, out int resto)
            System.Console.WrireLine("{0} {1}", resultado, resto) //Escreve "3 1"
        }
    }
}