using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista01_Ex03
{
    class C36985_Lista01_Ex03
    {
        static void Main(string[] args)
        {
            double xresult, diagonal;
            Console.Write("Informe a diagonal: ");
            diagonal = double.Parse(Console.ReadLine());
            xresult = diagonal * diagonal / 2;
            Console.Write("A área do quadrado é: " + xresult.ToString());
            Console.ReadKey();
        }
    }
}
