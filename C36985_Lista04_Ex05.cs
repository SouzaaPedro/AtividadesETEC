using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista04_Ex05
{
    internal class C36985_Lista04_Ex05
    {
        static void Main(string[] args)
        {
            int flag = 0, valorA = 0, soma = 0, valorB = 0, media = 10;

            do
            {
                Console.Write("Digite o primeiro valor: ");
                valorA = int.Parse(Console.ReadLine());

                soma = valorA + soma;

                if (valorA > valorB)
                {
                    valorB = valorA;
                }
                else { }
                flag ++;
                media = soma / flag;
            } while (soma < 100);
            Console.Write("O maior valor é: " + valorB.ToString());
            Console.WriteLine();

            Console.Write("A soma dos valores é: " + soma.ToString());
            Console.WriteLine();

            Console.Write("A média: " + media.ToString());
            Console.ReadKey();
        }
    }
}
