using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista04_Ex01
{
    internal class C36985_Lista04_Ex01
    {
        static void Main(string[] args)
        {
            int A = 0, B = 0;


            try
            {
                Console.Write("Digite o primeiro número(esse deverá ser o menor valor): ");
                A = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número(esse deverá ser o maior valor): ");
                B = int.Parse(Console.ReadLine());
                while (A >= B)
                {
                    Console.Write("Digite o segundo número novamente: ");
                    B = int.Parse(Console.ReadLine());
                }
            }

            catch
            {
                Console.Write("Digite apenas números");
                Console.ReadKey();
                return;
            }
            Console.Write("o maior número é " + B);
            Console.ReadKey();

        }
    }
}
