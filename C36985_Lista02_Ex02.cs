using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista02_Ex02
{
    class C36985_Lista02_Ex02
    {
        static void Main(string[] args)
        {
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura: ");
            Console.WriteLine("Digite o valor do raio da base: ");
            double raio = double.Parse(Console.ReadLine());
            double volume = 0.33 * Math.PI * Math.Sqrt(raio) * altura;
            Console.WriteLine("O valor do volume do cone é igual a: " + volume.ToString("0.00"));
            Console.ReadKey();


        }
    }
}
