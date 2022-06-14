using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista03_Ex10
{
    class C36985_Lista03_Ex10
    {
        static void Main(string[] args)
        {
            double p1 = 0, p2 = 0, notaMinima = 0, media = 0;
            try
            {
                Console.Write("Digite a nota da primeira avaliação: ");
                p1 = double.Parse(Console.ReadLine());
                notaMinima = (15 - p1) / 2;
                Console.WriteLine($"Para ser aprovado você precisa tirar no mínino nota: {notaMinima} ");
                Console.Write("Digite a nota da segunda avaliação: ");
                p2 = double.Parse(Console.ReadLine());
                media = (p1 + (2 * p2)) / 3;
            }
            catch
            {
                Console.WriteLine("Digite apenas números inteiros e/ou decimais.");
                Console.ReadLine();
                return;
            }
            if (media >= 5)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado.");
            }
            Console.ReadKey();
        }
    }
}
