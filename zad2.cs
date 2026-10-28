// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите количество студентов: ");
//         int students = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Введите количество предметов: ");
//         int subjects = Convert.ToInt32(Console.ReadLine());

//         int[,] grades = new int[students, subjects];

//         for (int i = 0; i < students; i++)
//         {
//             Console.WriteLine($"Студент {i + 1}");
//             for (int j = 0; j < subjects; j++)
//             {
//                 Console.Write($"Оценка по предмету {j + 1}: ");
//                 grades[i, j] = Convert.ToInt32(Console.ReadLine());
//             }
//         }

//         Console.WriteLine("\nСредние значения:");
//         for (int i = 0; i < students; i++)
//         {
//             double sum = 0;
//             for (int j = 0; j < subjects; j++)
//             {
//                 sum += grades[i, j];
//             }
//             double average = sum / subjects;
//             Console.WriteLine($"Студент {i + 1}: {average:F2}");
//         }
//     }
// }