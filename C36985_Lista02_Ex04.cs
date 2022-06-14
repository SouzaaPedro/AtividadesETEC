using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista02_Ex04
{
    class C36985_Lista02_Ex04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de raio: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da aresta>: ");
            double a = double.Parse(Console.ReadLine());
            double v = Math.Sqrt(a) * a - 4 / 3 * Math.PI * Math.Sqrt(r) * r;
            Console.Write("O volume livre do ambiente é: " + v.ToString("0.00"));
            Console.ReadKey();





        }
    }
}
