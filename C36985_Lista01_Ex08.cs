using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista01_Ex08
{
    class C36985_Lista_Ex08
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Indique quantas milhas marítimas: ");
            a = double.Parse(Console.ReadLine());
            b = a * 1852 / 1000;
            Console.WriteLine($"{a} milhas são {b} quilômetros");
            Console.ReadKey();
        }
    }
}
