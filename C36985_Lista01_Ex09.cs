using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista01_Ex09
{
    class C36985_Lista01_Ex09
    {
        static void Main(string[] args)
        {
            double tensao, vr, vc;
            Console.WriteLine("Informe o valor da resistência: ");
            vr = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da corrente: ");
            vc = double.Parse(Console.ReadLine());
            tensao = vr * vc;
            Console.WriteLine("A tensão é: "+ tensao.ToString());
            Console.ReadKey();
        }
    }
}
