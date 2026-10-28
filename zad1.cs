// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите размер массива N: ");
//         int n = Convert.ToInt32(Console.ReadLine());
        
//         int[] arr = new int[n];
//         int sum = 0;

//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"Элемент [{i}]: ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//             sum += arr[i];
//         }

//         Console.Write("Массив в обратном порядке: ");
//         for (int i = n - 1; i >= 0; i--)
//         {
//             Console.Write(arr[i] + " ");
//         }
//         Console.WriteLine();

//         double average = (double)sum / n;
//         Console.WriteLine($"Среднее арифметическое: {average:F2}");

//         int closest = arr[0];
//         double minDiff = Math.Abs(arr[0] - average);

//         for (int i = 1; i < n; i++)
//         {
//             double diff = Math.Abs(arr[i] - average);
//             if (diff < minDiff)
//             {
//                 minDiff = diff;
//                 closest = arr[i];
//             }
//         }
//         Console.WriteLine($"Число, максимально близкое к среднему: {closest}");
//     }
// }