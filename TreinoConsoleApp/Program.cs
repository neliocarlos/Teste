using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoConsoleApp
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Ex_001();
            Console.ReadKey();
        }

        public static void Ex_001()
        {
            Console.Write("Informe o salário base do funcionário:");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a idade do funcionário:");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe os anos de serviços prestados:");
            int anosServ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a quantidade de filhos:");
            int filhos = Convert.ToInt32(Console.ReadLine());
            double bonusFilhos = 0;
            double bonusServ;
            double bonusIdade;
            
            if (anosServ > 5)
            {
                bonusServ = (salario * 0.03) * anosServ - 5;
            }
            else
            {
                bonusServ = (salario * 0.005) * anosServ;
            }

            if (filhos >= 3)
            {
                bonusFilhos = salario * 0.02;
            }

            if (idade > 30)
            {
                bonusIdade = (idade / 1000) * salario;
            }
            else
            {
                bonusIdade = 0.01 * salario;
            }

            Console.WriteLine("O salário base do funcionário é de R${0}.", salario);
            Console.WriteLine("O bônus por quantidade de dependentes é de R${0}.", bonusFilhos);
            Console.WriteLine("O bônus por idade é de R${0}.", bonusIdade);
            Console.WriteLine("O bônus por serviço prestado é de R${0}.", bonusServ);
            double salarioFinal = salario + bonusServ + bonusFilhos + bonusIdade;
            Console.WriteLine("O salário final é de R${0}.", salarioFinal);
        }
    }
}
