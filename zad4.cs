// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Dictionary<string, string> phoneBook = new Dictionary<string, string>();

//         while (true)
//         {
//             Console.WriteLine("\nДоступные команды: добавление, поиск, просмотр, выход");
//             Console.Write("Введите команду: ");
//             string command = Console.ReadLine().ToLower();

//             if (command == "выход") break;

//             if (command == "добавление")
//             {
//                 Console.Write("Введите имя: ");
//                 string name = Console.ReadLine();
//                 Console.Write("Введите номер: ");
//                 string phone = Console.ReadLine();
                
//                 phoneBook[name] = phone; 
//                 Console.WriteLine("Контакт сохранен.");
//             }
//             else if (command == "поиск")
//             {
//                 Console.Write("Введите имя для поиска: ");
//                 string name = Console.ReadLine();
//                 if (phoneBook.ContainsKey(name))
//                     Console.WriteLine($"Номер: {phoneBook[name]}");
//                 else
//                     Console.WriteLine("Контакт не найден.");
//             }
//             else if (command == "просмотр")
//             {
//                 Console.WriteLine("Телефонная книга");
//                 foreach (var contact in phoneBook)
//                 {
//                     Console.WriteLine($"{contact.Key}: {contact.Value}");
//                 }
//             }
//         }
//     }
// }