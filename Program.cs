using System;
using System.IO;

namespace Lab3_OOP
{
    class Person
    {
        string name;
        int birth_year;
        double pay;

        public Person() 
        {
            name = "Anonimous";
            birth_year = 0;
            pay = 0;
        }

        public Person(string s)  
        {
            string[] split = s.Split(new Char[] { ' ' });  
            name = split[0].Trim();  
            birth_year = Convert.ToInt32(split[1].Trim());  
            pay = Convert.ToDouble(split[2].Trim()); 

            if (birth_year < 0) throw new FormatException("Invalid birth year");
            if (pay < 0) throw new FormatException("Invalid pay value");
        }

        public override string ToString()  
        {
            return string.Format("Name: {0} Birth Year: {1} Pay: {2:F2}", name, birth_year, pay);
        }

        
        public static void ReadPersonsFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);  

                foreach (string line in lines)
                {
                    try
                    {
                        Person person = new Person(line); 
                        Console.WriteLine(person.ToString());  
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine($"Error processing line: {line} - {e.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        public static void ReadPersonsFromConsole()
        {
            Console.WriteLine("Enter person data (Format: 'Name Year Pay'). Enter an empty line to finish:");
            string input;
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                try
                {
                    Person person = new Person(input);
                    Console.WriteLine(person.ToString());
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }

        
        static void Main(string[] args)
        {
            
            ReadPersonsFromConsole();
        }
    }
}
