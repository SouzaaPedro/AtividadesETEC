using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista04_Ex04
{
    internal class C36985_Lista04_Ex04
    {
        static void Main(string[] args)
        {
            double valor, contagem = 0, MaiorValor = 0, soma = 0, média;
            do
            {
                Console.Write("Digite apenas números positivos: ");
                valor = double.Parse(Console.ReadLine());
                contagem = contagem + 1;
                soma = soma + valor;
                média = soma / contagem;
            } while (contagem < 10);

            if (valor < 0)
            {
                Console.Write("Digite apenas números positivos: ");
                valor = double.Parse(Console.ReadLine());
                if (valor > 0)
                {
                    if (valor > MaiorValor)
                    {
                        MaiorValor = valor;
                    }
                }
                else
                {
                    Console.Write("ERRO!");
                }
            }
            else
            {
                if (valor > MaiorValor)
                {
                    MaiorValor = valor;
                }
                else
                {
                    Console.Write("ERRO!");
                }
            }

            Console.Write("Maior valor: " + MaiorValor + "\nSoma: " + soma + "\nMédia: " + média);

            Console.ReadKey();
        }
    }
}
