using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista01_Ex06
{
    class C36985_Lista01_Ex06
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0, d = 0, soma = 0;
            Console.WriteLine("Informe o primeiro valor: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro valor: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o quarto valor: ");
            d = double.Parse(Console.ReadLine());
            soma = a + b + c + d;
            double media = soma / 4;
            Console.WriteLine("A média é: " + media.ToString());
            Console.ReadKey();
        }
    }
}
