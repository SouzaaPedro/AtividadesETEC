using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista02_Ex05
{
    class C36985_Lista02_Ex05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor em dólares: ");
            double dolar = double.Parse(Console.ReadLine());
            double real = dolar * 4.76;
            Console.WriteLine($"O valor de US${dolar} é igual a R${real}");
            Console.ReadKey();




        }
    }
}
