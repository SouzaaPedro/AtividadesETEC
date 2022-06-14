using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista01_Ex01
{
    class C36985_Lista01_Ex01
    {
        static void Main(string[] args)
        {
            double xbase = 0, yaltura = 0, zarea = 0;
            Console.WriteLine("Informe a base:");
            xbase = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura");
            yaltura = double.Parse(Console.ReadLine());
            zarea = xbase * yaltura;
            Console.WriteLine("A área do triângulo é:" + zarea.ToString());
            Console.ReadKey();
        }
    }
}
