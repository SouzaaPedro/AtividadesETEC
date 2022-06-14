using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista04_Ex02
{
    internal class C36985_Lista04_Ex02
    {
        static void Main(string[] args)
        {
            string valorS = "";


            try
            {
                do
                {
                    Console.Write("Digite 'F' para feminino e 'M' para masculino: ");
                    valorS = Console.ReadLine();
                }

                while (valorS != "F" && valorS != "M");

                if (valorS == "F")
                {
                    Console.Write("seu genêro é feminino");
                }

                else
                {
                    Console.Write("seu genêro é masculino");
                }
            }
            catch
            {
                Console.Write("Digite somente letras");

            }
            Console.ReadKey();
        }
    }
}
