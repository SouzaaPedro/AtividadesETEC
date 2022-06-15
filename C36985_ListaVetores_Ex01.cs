using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_ListaVetores_Ex01
{
    internal class C36985_ListaVetores_Ex01
    {
        static void Main(string[] args)
        {
            // Criar um vetor A com 10 elementos inteiros. Implementar um programa que defina e escreva a quantidade de elementos armazenados neste vetor que são pares.

            int[] numero = new int[10];
            int binNumero = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número inteiro positivo: ");
                numero[i] = int.Parse(Console.ReadLine());
                while (numero[i] < 0)
                {

                    Console.Write("ERRO!! ");
                    Console.Write("Digite um númeor inteiro positivo: ");
                    int.Parse(Console.ReadLine());   
                }
                if (numero[i] % 2 == 0)
                {
                    binNumero++;
                }
            }
            Console.WriteLine($"Existem {binNumero} números inteiros pares acima ");
            Console.ReadKey();
        }
    }
}
