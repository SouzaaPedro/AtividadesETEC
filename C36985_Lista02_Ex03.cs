using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista02_Ex03
{
    class C36985_Lista02_Ex03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da velocidade inicial(m/s): ");
            double VelocidadeInicial = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da aceleração (m/s2): " );
            double aceleracao = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do tempo de percurso (s): ");
            double TempoPercurso = double.Parse(Console.ReadLine());
            double VelocidadeFinal = TempoPercurso * aceleracao + VelocidadeInicial;
            Console.WriteLine("O valor da velocidade final do automóvel é: " + VelocidadeFinal.ToString("0.00") + "km/h");
            Console.ReadKey();



        }
    }
}
