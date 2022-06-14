using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista03_Ex01
{
    class C36985_Lista03_Ex01
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Insira um valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo valor: ");
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.Write("O valor " + a.ToString() + " é maior que o valor " + b.ToString());
            }
            else if (b > a)
                Console.Write("O valor " + b.ToString() + " é maior que o valor " + a.ToString());
            Console.ReadKey();
            {

                
            }




        }
    }
}
