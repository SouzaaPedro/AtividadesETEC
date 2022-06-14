using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista03_Ex08
{
    class C36985_Lista03_Ex08
    {
        static void Main(string[] args)
        {
            double A = 0, B = 0, C = 0, teste = 0, soma = 0;
            try
            {
                Console.Write("Digite o valor da hipotenusa: ");
                A = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor do primeiro cateto: ");
                B = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor do segundo cateto: ");
                C = double.Parse(Console.ReadLine());
                teste = Math.Pow(A, 2);
                soma = Math.Pow(B, 2) + Math.Pow(C, 2);
            }
            catch
            {
                Console.WriteLine("Digite apenas números inteiros e/ou decimais.");
                Console.ReadKey();
                return;
            }
            if(teste == soma)
            {
                Console.WriteLine("Os lados formam um triângulo retângulo. ");
            }
            else
            {
                Console.WriteLine("Os lados digitados não formam um triângulo retângulo.");
            }
            Console.ReadKey();
        }
    }
}
