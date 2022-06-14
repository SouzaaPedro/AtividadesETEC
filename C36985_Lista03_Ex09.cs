using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista03_Ex09
{
    class C36985_Lista03_Ex09
    {
        static void Main(string[] args)
        {
            double p1 = 0, p2 = 0, media = 0;
            try
            {
                Console.Write("Digite a nota da primeira avaliação: ");
                p1 = double.Parse(Console.ReadLine());
                Console.Write("Digite a nota da segunda avaliação: ");
                p2 = double.Parse(Console.ReadLine());
                media = (p1 + (2 * p2)) / 3;
            }
            catch
            {
                Console.WriteLine("Digite apenas números inteiros e/ou decimais. ");
                Console.ReadKey();
                return;
            }
            if(media>=5)
            {
                Console.WriteLine("Aprovado!.");
            }
            else
            {
                Console.WriteLine("Reprovado!.");
            }
            Console.ReadKey();


        }
    }
}
