// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         List<int> numbers = new List<int>();
//         HashSet<int> seen = new HashSet<int>();

//         Console.WriteLine("Вводите числа:");

//         while (true)
//         {
//             Console.Write("Число: ");
//             int num = Convert.ToInt32(Console.ReadLine());

//             if (seen.Contains(num))
//             {
//                 Console.WriteLine($"Число {num} уже встречалось");
//                 break;
//             }

//             numbers.Add(num);
//             seen.Add(num);
//         }

//         Console.WriteLine("Ваш массив: " + string.Join(", ", numbers));
//     }
// }