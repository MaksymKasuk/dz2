using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    internal class V2
    {
      

class Employee
    {
        public string Surname { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        
        public void AnalyzeSalary(string surname, double salary)
        {
            if (salary < 3000)
            {
                Console.WriteLine($"{surname} - Мізерна зарплата: {salary}");
            }
            else if (salary >= 3000 && salary < 5000)
            {
                Console.WriteLine($"{surname} - Така собі зарплата: {salary}");
            }
            else if (salary >= 5000)
            {
                Console.WriteLine($"{surname} - Непогана зарплата: {salary}");
            }
        }

        
        public void AnalyzeSalary(string surname, string position, double salary)
        {
            if (position.ToLower() == "менеджер" && salary <= 3000)
            {
                Console.WriteLine($"{surname} - Шукай кращу роботу!");
            }
            else
            {
                Console.WriteLine($"{surname} - {position}, Зарплата: {salary}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee1 = new Employee();
            employee1.AnalyzeSalary("Іваненко", 2500);
            employee1.AnalyzeSalary("Петренко", 3500);
            employee1.AnalyzeSalary("Сидоренко", 6000);

            
            Employee employee2 = new Employee();
            employee2.AnalyzeSalary("Іваненко", "менеджер", 2800);
            employee2.AnalyzeSalary("Петренко", "інженер", 4500);
        }
    }

}
}
