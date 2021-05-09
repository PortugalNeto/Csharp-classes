using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa de impressão de pirâmide!");
            Console.Write("Quantas linhas quer que tenha sua pirâmide: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int number = 1;
            int stars = 2 * rows - 1;
            int spaces = rows - 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < number; k++)
                {
                    Console.Write("*");
                }
                for (int m = 0; m < spaces; m++)
                {
                    Console.Write(" ");
                }
                spaces -= 1;
                number += 2;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
