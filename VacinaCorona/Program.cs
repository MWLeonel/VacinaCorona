using System;

namespace VacinaCorona
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, vacina;

            Console.WriteLine("<======Vacina do CoronaVirus======>");

            Console.Write("Qual Seu Nome: ");
            nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"{nome} você deseja toamr a vacina contra a covid-19?");
            Console.Write("Sim ou Não? ");
            vacina = Console.ReadLine().ToUpper();

            if (vacina == "S" || vacina == "SIM")
            {
                Console.WriteLine();
                Console.WriteLine($"{nome} parabens, a partir de amanha você estará imune ao coronavirus");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"{nome} parabens, a partir de amanha você vai morrer. Então aproveite seu ultimo dia de vida :)");
            }
        }
    }
}
