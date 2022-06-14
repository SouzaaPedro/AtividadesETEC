using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista01_Ex04
{
    class C36985_Lista01_Ex04
    {
        static void Main(string[] args)
        {
            double xbase, yaltura, ztriangulo;
            Console.WriteLine("Informe a base do triângulo: ");
            xbase = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura do triângulo: ");
            yaltura = double.Parse(Console.ReadLine());
            ztriangulo = xbase * yaltura / 2;
            Console.WriteLine($"A área do triângulo é: {ztriangulo}");
            Console.ReadKey();
        }
    }
}
