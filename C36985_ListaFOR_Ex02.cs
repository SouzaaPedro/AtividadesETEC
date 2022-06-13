using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_ListaFOR_Ex02
{
    internal class C36985_ListaFOR_Ex02
    {
        static void Main(string[] args)
        {
            /* Entrar via teclado com “N” valores quaisquer. O valor “N” (que representa a quantidade de números) será digitado, deverá ser positivo, mas menor que vinte. Caso a quantidade não satisfaça a restrição, enviar mensagem de erro e solicitar o valor novamente. Após a digitação dos “N” valores, exibir:
O maior valor;
O menor valor;
A soma dos valores;
A média aritmética dos valores;
A porcentagem de valores que são positivos;
A porcentagem de valores negativos; */






            Console.ForegroundColor = ConsoleColor.Green;



            double QN = 0, QNC = 0, NumeroUsuario = 0, Maior = 0, Soma = 0, Media = 0, Menor = double.PositiveInfinity, PorcentagemNegativa = 0, PorcentagemPositiva = 0, ContagemNegativa = 0, ContagemPositiva = 0;



            Console.Write("Digite a quantidade de valores a serem digitados: ");
            QN = double.Parse(Console.ReadLine());



            if (QN > 20 || QN < 1)
            {
                do
                {



                    Console.WriteLine(" A quantidade dos valores deverá ser menor que 20 e positivos. \n Digite novamente: ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;




                    QNC = double.Parse(Console.ReadLine());



                } while (QNC > 20 || QNC < 1);
            }



            else
            {
                QNC = QN;
            }




            #region For Numero usuario
            for (int i = 0; i < QNC; i++)
            {
                Console.Write(" Digite um número: ");
                NumeroUsuario = double.Parse(Console.ReadLine());
                if (NumeroUsuario < 0)
                {
                    ContagemNegativa++;
                }
                else
                {
                    ContagemPositiva++;
                }



                Soma = Soma + NumeroUsuario;

                if (NumeroUsuario < Menor)
                {
                    Menor = NumeroUsuario;
                }



                if (Maior < NumeroUsuario)
                {
                    Maior = NumeroUsuario;
                }



            }
            #endregion




            Media = Soma / QNC;




            PorcentagemPositiva = (ContagemPositiva * 100) / QNC;
            PorcentagemNegativa = (ContagemNegativa * 100) / QNC;












            Console.WriteLine(" O Maior valor é: " + Maior + "\n O menor dos valores é: " + Menor + "\n Soma dos valores é: " + Soma + "\n A média dos valores é: " + Media + "\n Porcentagem Negativa é: " + PorcentagemNegativa + "%" + "\n Porcentagem positiva é: " + PorcentagemPositiva + "%");





            Console.ReadKey();




        }
    }
}
