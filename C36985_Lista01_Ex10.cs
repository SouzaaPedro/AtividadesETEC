using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista01_Ex10
{
    class C36985_Lista01_Ex10
    {
        static void Main(string[] args)
        {
            double tc, tf;
            Console.WriteLine("Qual o valor da temperatura: ");
            tc = double.Parse(Console.ReadLine());
            tf = (tc * 9 / 5) + 32;
            Console.WriteLine("O valor da temperatura com Fahrenheit é: " + tf.ToString());
            Console.ReadKey();
        }
    }
}
