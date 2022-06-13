using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_ListaFOR_Ex01
{
    internal class C36985_ListaFOR_Ex01
    {
        static void Main(string[] args)
        {
            double Soma = 0, NumeroUsuario = 0, Maior = 0, Media = 0;

            try
            {

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(" Digite um número: ");
                    NumeroUsuario = double.Parse(Console.ReadLine());

                    if (Maior < NumeroUsuario)
                    {
                        Maior = NumeroUsuario;
                    }



                    Soma = Soma + NumeroUsuario;

                }

                Media = Soma / 10;

            }
            catch
            {
                Console.Write(" Digite apenas números. ");
                Console.ReadKey();

                return;
            }


            Console.WriteLine(" Maior valor é: " + Maior + "\n Soma dos valores é: " + Soma + "\n Média dos valores é: " + Media);

            Console.ReadKey();

        }
    }
}
