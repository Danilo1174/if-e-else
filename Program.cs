using System;

namespace atividade_if_else
{
    class Program
    {
        private static int escolha;

        static void Main(string[] args)


        {

            Console.WriteLine("escolha um exercicio a ser executado");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha != 0)
            {
             case 1:
                        #region exercicio 1



                int a, b;

                Console.WriteLine("digite o valor de a: ");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("digite o valor de b : ");
                b = int.Parse(Console.ReadLine());

                if (a % b == 0 || b % a == 0)
                {
                    Console.WriteLine("são multiplos");
                }
                else
                {
                    Console.WriteLine("não são multiplos");
                }



                #endregion
                break;
                
             case 2:

                        #region exercicio 2


                int codigo, quantidade;
                double preco = 0.0;

                Console.WriteLine("codigo   | especificacao   |   preco ");
                Console.WriteLine("  1      | cachorro quente |   r$4.00");
                Console.WriteLine("  2      | x-salada        |   r$4.50");
                Console.WriteLine("  3      | x-bacon         |   r$5.00");
                Console.WriteLine("  4      | bauru           |   r$2.50");
                Console.WriteLine("  5      | refrigerante    |   r$1.50");



                Console.WriteLine("digite o código: ");
                codigo = int.Parse(Console.ReadLine());

                Console.WriteLine("digite a quantidade: ");
                quantidade = int.Parse(Console.ReadLine());

                if (codigo == 1)
                {
                    preco = 4.00 * quantidade;
                }
                else if (codigo == 2)
                {
                    preco = 4.50 * quantidade;
                }
                else if (codigo == 3)
                {
                    preco = 5.00 * quantidade;
                }
                else if (codigo == 4)
                {
                    preco = 2.00 * quantidade;
                }
                else if (codigo == 5)
                {
                    preco = 1.50 * quantidade;
                }

                Console.WriteLine("total: R${0:f2}", preco);

                #endregion

                break;

             case 3:
                         #region exercicio 3




                Console.WriteLine("digite o valor de x: ");
                double x = double.Parse(Console.ReadLine());

                Console.WriteLine("digite o valor de y:");
                double y = double.Parse(Console.ReadLine());


                if (x == 0.0 && y == 0.0)
                {
                    Console.WriteLine("origem");
                }
                else if (x == 0.0)
                {
                    Console.WriteLine("eixo y");
                }
                else if (y == 0.0)
                {
                    Console.WriteLine("eixo x");
                }
                else if (x > 0.0 && y > 0.0)
                {
                    Console.WriteLine("q1");
                }
                else if (x < 0.0 && y > 0.0)
                {
                    Console.WriteLine("q2");
                }
                else if (x < 0.0 && y < 0.0)
                {
                    Console.WriteLine("q3");
                }
                else
                {
                    Console.WriteLine("q4");
                }
                #endregion
                break;
            }
        }
    }
}

