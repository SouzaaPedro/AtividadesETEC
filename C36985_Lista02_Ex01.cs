using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista02_Ex01
{
    class C36985_Lista02_Ex01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o do círculo:");
            double diametro = double.Parse(Console.ReadLine());
            double raio = diametro / 2;
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine("O valor da área do círculo é:" + area.ToString("0.00"));
            Console.ReadKey();




        }
    }
}
