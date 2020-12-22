namespace Metodos.metodos
{
    public class ref
    {
        static void InverterNumeros(ref int a,ref int b) //com ref cria um impacto entre as 2
        {
            int temp = x;
            x = y;
            y = temp;
        }

        //O que acontece no metodo acima, não interfere no metodo abaixo

        public static void InverterNumeros()
        {
            int i = 12, l = 24;
            InverterNumeros(i , l )
            System.Console.WrireLine($"{i} e {l}")
        }
    }
}