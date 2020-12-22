using System;

namespace CSharpOperadores
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b = 2, c = 3;
            //uma contante não permite a auteração de uma variavel
            const int d = 4;
            a = 1;
            Console.WriteLine(a + b +c + d);
        }
        static void operadorCondicional(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Sem itens");
            }else if( args.Length == 1)
            {
                Console.WriteLine("1 item");
            }else
            {
                Console.WriteLine($"{args.Length} argumentos");
            }
        }
        static void operadorSwithCase(string[] args)
        {
            int argumentos = args.Length;
            switch(argumentos)
            {
                case 0:
                    Console.WriteLine("Coma Alho");
                    break;
                case 1:
                    Console.WriteLine("Beba Alho");
                    break;
                default:
                    Console.WriteLine($"{argumentos} alhos");
                    break;
            }
        }
        static void operadorDeRepetição(string[] args)
        {
            //while
            int cont = 0;
            while(cont <= 10)
            {
                Console.WriteLine($"{cont} alhos");
                cont++;
            }

            ////DoWhile
            do
            {
                var alho = Console.ReadLine();
                Console.WriteLine($"{cont} kilos de {alho}");
                cont++;
            }
            while(cont < 10);
            
            //for
            for(int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            };
            //forEach
            foreach(string s in args)
            {
                Console.WriteLine(s);
            }

        }
        static void breakOperador(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite um valor:");
                string valor = Console.ReadLine();
                if(string.IsNullOrEmpty(valor))
                {
                    break;
                };
            };
        }
        static void continueOperador(string[] args)
        {
            for(int i = 0; i <= 10; i++){
                if( i == 5)
                {
                    continue;
                };
            }
        }
        static void returnOperador(string[] args)
        {
            int Somar(int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(Somar(24, 24));
            Console.WriteLine(Somar(24, 0));
            Console.WriteLine(Somar(24, 96));
            Console.WriteLine(Somar(24, 48));

        }
        static void ExceptionsTryCatchFinnaly(string[] args)
        {
            double Dividir(double x, double y)
            {
                if(y == 0)
                    throw new DivideByZeroException();

                return x/y;
            };
            
            try
            {
                if(args.Length != 2)
                {
                    throw new InvalidOperationException("Coma alho");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x, y));
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error {e}!");
            }
            finally
            {
                Console.WriteLine("Deu Certo !");
            }

        }
        static void usingM(string[] args)
        {

            //OPERAÇÕES COM IO (INPUT E OUTPUT)
            System.IO.TextWriter w;
            w = System.IO.File.CreateText("texte.txt");
            w.WriteLine("alho");

            w.Dispose(); //elimina o objeto w, da memoria

            // OUTRA MANEIRA DE SE FAZER O Q FOI FEITO ACIMA ↑
            // using (System.IO.TextWriter i = System.IO.File.CreateText("texte.txt"))
            // {
            //     i.WriteLine("alho");
            //     i.WriteLine("Cebola");
            //     i.WriteLine("Chuchu");
            // }
        }
        static void array(string[] args)
        {
            //array dimencional
            int[] a = new int[10];
            int cont = 0;
            while(cont <= a.Length)
            {
                Console.WriteLine(a[cont]);
                cont++;
            };

            //array multidimencional(matriz)
            int[,] a2 = new int[1,5];
            int[,,] a3 = new int[1,5,10];

            int[] a4 = { 1, 2, 3, 4 };
        }
    }
}
