using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista01_ex07
{
    class C36985_Lista01_Ex07
    {
        static void Main(string[] args)
        {
            double v1, v2, mediag, multi;
            Console.WriteLine("Informe o primeiro valor: ");
            v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo: ");
            v2 = double.Parse(Console.ReadLine());
            multi = v1 * v2;
            mediag = Math.Sqrt(multi);
            Console.WriteLine("A média geométrica é: "+ mediag.ToString());
            Console.ReadKey();
        }
    }
}
