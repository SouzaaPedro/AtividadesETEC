using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista03_Ex07
{
    class C36985_Lista03_Ex07
    {
        static void Main(string[] args)
        {
            double valor1 = 0, valor2 = 0, valor3 = 0, soma1 = 0, soma2 = 0, soma3 = 0;

            try
            {
                Console.Write("Digite o primeiro valor: ");
                valor1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                valor2 = double.Parse(Console.ReadLine());
                Console.Write("Digite o terceiro valor: ");
            }
            catch
            {
                Console.WriteLine("Digite apenas números inteiros e/ou decimais.");
                Console.ReadKey();
                return;
            }

            soma1 = valor1 + valor2; // > valor3
            soma2 = valor1 + valor3; // > valor2
            soma3 = valor2 + valor3; // > valor1 

            if (soma1 > valor3 && soma2 > valor2 && soma3 > valor1)
            {
                if (valor1 != valor2 && valor2 != valor3)
                {
                    Console.WriteLine("Os dois lados formam um triângulo escaleno.");
                }
                else if (valor1 == valor2 && valor2 == valor3)
                {
                    Console.WriteLine("Os lados formam um triângulo equilátero.");
                }
                else
                {
                    Console.WriteLine("Os lados formam um triângulo isósceles.");
                }
            }
            else
            {
                Console.WriteLine("Não formam um triângulo");
            }
            Console.ReadKey();
        }
    }
}
