﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class C36985_ListaFOR_Ex03
    {
        static void Main(string[] args)
        {
            /*  Entrar via teclado com “N” valores quaisquer. O valor “N” (que representa a quantidade de números) será digitado, deverá
                ser positivo, mas menor que vinte.Caso a quantidade não satisfaça a restrição, enviar mensagem de erro e solicitar o 
                valor novamente.Após a digitação dos “N” valores, exibir:
                a.O maior valor;
                b.O menor valor;
                c.A soma dos valores;
                d.A média aritmética dos valores;
                e.A porcentagem de valores que são positivos;
                f.A porcentagem de valores negativos;
                Após exibir os dados, perguntar ao usuário de deseja ou não uma nova execução do programa.
                Consistir a resposta no sentido de aceitar somente “S” ou “N” e encerrar o programa em função dessa resposta.
            */
            string answer = "S";
            try
            {
                while (answer == "S")
                {
                    int numbers;
                    double value, bigger = 1, lower, sum = 0, average, negativeValue = 0, positiveValue = 0, pcPositiveValue = 0, pcNegativeValue = 0;
                    Console.Clear();
                    Console.Write("Quantidade de números positivos a serem digitados: ");
                    numbers = int.Parse(Console.ReadLine());
                    lower = double.PositiveInfinity;
                    for (int i = 1; i <= numbers; i++)
                    {
                        while (numbers <= 0 || numbers >= 20)
                        {
                            Console.Write("Erro! Digite apenas números positivos > 0 e < 20: ");
                            numbers = int.Parse(Console.ReadLine());
                        }
                        Console.Write("Digite um número: ");
                        value = double.Parse(Console.ReadLine());

                        if (bigger < value)
                        {
                            bigger = value;
                        }
                        if (value < bigger)
                        {
                            bigger = value;
                        }

                        sum += value;

                        if (value > 0)
                        {
                            positiveValue++;
                        }
                        if (value < 0)
                        {
                            negativeValue++;
                        }
                    }

                    pcPositiveValue = (positiveValue * 100) / numbers;
                    pcNegativeValue = (negativeValue * 100) / numbers;

                    average = sum / numbers;
                    Console.WriteLine("");
                    Console.WriteLine($"O maior valor: {bigger}\nO menor valor: {lower}\nSoma dos valores: {sum}\nMédia aritmética dos valores: {average}\nA porcentagem de valores positivos: {pcPositiveValue}%\nA porcentagem de valores negativos: {pcNegativeValue}% ");
                    Console.WriteLine("");

                    Console.WriteLine("Digite 'S' para sim ou 'N' para não");
                    Console.WriteLine("Deseja refazer o programa? ");
                    answer = Console.ReadLine();

                    while (answer != "S" && answer != "N")
                    {
                        Console.WriteLine("Digite 'S' para sim ou 'N' para não");
                        Console.WriteLine("Deseja refazer o programa? ");
                        answer = Console.ReadLine();
                    }
                }
                Console.WriteLine("Encerrando...");
                Console.ReadKey();
            }
            catch
            {
                Console.Write("Digite apenas números!");
                Console.ReadKey();
                return;
            }
        }
    }
}