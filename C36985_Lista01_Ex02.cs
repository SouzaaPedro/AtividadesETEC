using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista01_Ex02
{
    class C36985_Lista01_Ex02
    {
        static void Main(string[] args)
        {
            double result, aresta;
            Console.WriteLine("Digite o valor da aresta:");
            aresta = double.Parse(Console.ReadLine());
            result = aresta * aresta;
            Console.Write("A área do quadrado é:"+ result.ToString());
            Console.ReadKey();
        }
    }
}
