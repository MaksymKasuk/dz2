using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    internal class V3
    {
  

class Student
    {
        private string name;
        private int age;
        private int course;
        private double[] grades = new double[10]; 

        public Student(string name, int age, int course)
        {
            this.name = name;
            this.age = age;
            this.course = course;
        }

        
        public double this[int index]
        {
            get
            {
                if (index >= 0 && index < grades.Length)
                {
                    return grades[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Невірний індекс!");
                }
            }
            set
            {
                if (index >= 0 && index < grades.Length)
                {
                    grades[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Невірний індекс!");
                }
            }
        }

        
        public double CalculateAverageRating()
        {
            double total = 0;
            int count = 0;

           
            foreach (double grade in grades)
            {
                total += grade;
                count++;
            }

            return total / count;
        }

       
        public void DisplayInfo()
        {
            Console.WriteLine($"Студент: {name}, Вік: {age}, Курс: {course}");
            Console.WriteLine("Оцінки за кредит з дисциплін:");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"Дисципліна {i + 1}: {grades[i]}");
            }
            Console.WriteLine($"Середній рейтинг: {CalculateAverageRating():F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student("Іваненко", 19, 2);

           
            student[0] = 85;
            student[1] = 90;
            student[2] = 78;
            student[3] = 88;
            student[4] = 92;
            student[5] = 79;
            student[6] = 83;
            student[7] = 95;
            student[8] = 87;
            student[9] = 91;

            
            student.DisplayInfo();
        }
    }

}
}
