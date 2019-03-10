using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student("Gjurgica", "SEDC", "G2");
            students[1] = new Student("Gorjan", "Code Academy", "G1");
            students[2] = new Student("Ana", "Code Academy", "G1");
            students[3] = new Student("Bojan", "SEDC", "G2");
            students[4] = new Student("Dario", "SEDC", "G1");
            Console.WriteLine("Enter a student name");
            string answer = Console.ReadLine();
            bool studentFound = false;
            while(studentFound == false)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (answer == students[i].Name)
                    {
                        Console.WriteLine($"{students[i].Name} is student in {students[i].Academy} in {students[i].Group} group.");
                        studentFound = true;
                    }
                }
                if(studentFound == false)
                {
                    Console.WriteLine("This student not exist");
                    answer = Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
    
}
