/*
using System;

class Program
{
    static void Main()
    {
        int[,] matrix1 = new int[3, 3];
        int[,] matrix2 = new int[3, 3];

        Console.WriteLine("Введите числа:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Строка {i + 1}: ");
            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j < 3; j++)
            {
                matrix1[i, j] = Convert.ToInt32(input[j]);
            }
        }

        Console.WriteLine("\nБыло:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix1[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix2[j, i] = matrix1[i, j];
            }
        }

        Console.WriteLine("\nСтало:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix2[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/