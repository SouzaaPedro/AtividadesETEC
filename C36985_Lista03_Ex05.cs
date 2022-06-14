using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista03_Ex05
{
    class C36985_Lista03_Ex05
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a base do retângulo: ");
            double Base = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura do retângulo: ");
            double Altura = double.Parse(Console.ReadLine());

            double Area = Base * Altura;

            if (Area > 100)
            {
                Console.Write("Terreno Grande");
            }

            else
            {
                Console.Write("Terreno Pequeno");
            }


            Console.ReadKey();




        }
    }
}
