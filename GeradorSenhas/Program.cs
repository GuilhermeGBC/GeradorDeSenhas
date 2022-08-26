using System;
using System.Text;

namespace GeradorSenhas
{
    class Program
    {
        static void Main(string[] args)
        {
            int qntdChars;
            string letras = "abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine("Quantos caracteres deseja em sua senha?");
            int.TryParse(Console.ReadLine(), out qntdChars);

            Console.WriteLine("Deseja letras maiúsculas na sua senha? (S/N)");
            string resultado1 = Console.ReadLine();

            Console.Clear();

            if (resultado1 == "S" || resultado1 == "s")
                letras += "abcdefghijklmnopqrstuvwxyz".ToUpper();

            Console.WriteLine("Deseja algarismos na sua senha?");
            string resultado2 = Console.ReadLine();

            Console.Clear();

            if (resultado2 == "S" || resultado2 == "s")
                letras += "0123456789";

            Console.WriteLine("Deseja caracteres especiais na senha?");
            string resultado3 = Console.ReadLine();

            Console.Clear();

             if (resultado3 == "S" || resultado3 == "s")
                letras += "#/$!?=-\"";

            var random = new Random();

            StringBuilder str = new StringBuilder();

            for (int m = 1; m <= qntdChars; m++)
            {
                int posicao = random.Next(0, letras.Length);
                str.Append(letras[posicao].ToString());
            }

            Console.WriteLine($"{str.ToString()}");

        }
    }
}
