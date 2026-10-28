/*
using System;

class Program
{
    static void Main()
    {
        int studentsCount = 3;
        int gradesCount = 5;

        for (int i = 1; i <= studentsCount; i++)
        {
            double sum = 0;
            Console.WriteLine($"cтудент {i}");
            
            for (int j = 1; j <= gradesCount; j++)
            {
                Console.Write($"Введите оценку {j}: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                sum = sum + grade;
            }

            double average = sum / gradesCount;
            Console.WriteLine($"Средний балл студента {i}: {average:F2}\n");
        }
    }
}
*/