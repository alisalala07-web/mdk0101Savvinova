using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EmployeeApp
{
    class Program
    {
        static void Main()
        {
            File.WriteAllText("log.txt", "", Encoding.UTF8);
            DataReader reader = new DataReader();
            List<Employee> employees = reader.ReadEmployees("employee.txt");

            if (employees.Count > 0)
            {
                double averageSalary = employees.Average(e => e.Salary);
                Employee oldest = employees.OrderByDescending(e => e.Age).First();

                string resultText = $"Всего сотрудников: {employees.Count}\n" +
                                    $"Средняя зарплата: {averageSalary:F2}\n" +
                                    $"Самый старший: {oldest.Name} ({oldest.Age} лет)";

                File.WriteAllText("result.txt", resultText, Encoding.UTF8);
                
                Console.WriteLine("Аналитика готова! Проверьте файл result.txt");
                Console.WriteLine(resultText);
            }
            else
            {
                Console.WriteLine("Не удалось прочитать ни одного сотрудника.");
            }
        }
    }
}