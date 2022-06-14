using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista03_Ex03
{
    class C36985_Lista03_Ex03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================");
            Console.WriteLine("QUAL É O MAIOR NÚMERO?");
            Console.WriteLine("========================");

            Console.Write("Digite o primeiro número: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            double z = double.Parse(Console.ReadLine());

            if (x > y && x > z)
            {
                Console.WriteLine($"O maior número é: {x}");
            }
            else
            {
                if (y > x && y > z)
                {
                    Console.WriteLine($"O maior número é: {y}");
                }
                else
                {
                    if (z > x && z > y)
                    {
                        Console.WriteLine($"O maior número é: {z}");
                    }
                    else if (x == y || y == z)
                    {
                        Console.WriteLine("Os três números são iguais");
                    }
                    else if (x == z)
                    {
                        Console.WriteLine("O primeiro e segundo números são iguais e são maiores");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
