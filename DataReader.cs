using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EmployeeApp
{
    public class DataReader
    {
        public List<Employee> ReadEmployees(string filePath)
        {
            List<Employee> employees = new List<Employee>();
            
            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                
                if (string.IsNullOrWhiteSpace(line)) continue;

                try
                {
                    string[] parts = line.Split(';');

                    if (parts.Length < 3)
                        throw new Exception("Недостаточно данных в строке.");

                    Employee emp = new Employee
                    {
                        Name = parts[0].Trim(),
                        Age = int.Parse(parts[1].Trim()),
                        Salary = double.Parse(parts[2].Trim())
                    };

                    employees.Add(emp);
                }
                catch (Exception ex)
                {
                    string logMessage = $"Ошибка в строке {i + 1}: {ex.Message}";
                    File.AppendAllText("log.txt", logMessage + Environment.NewLine, Encoding.UTF8);
                }
            }
            return employees;
        }
    }
}