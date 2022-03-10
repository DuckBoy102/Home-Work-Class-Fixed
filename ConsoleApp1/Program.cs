using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter the student's name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the student's ID");
                int ID = int.Parse(Console.ReadLine());
                Student Student = new Student(name, ID, -1);
                Student.CalculateAverage();
                Console.WriteLine("The student's average grade is {0}", Student.Grade);
            }
        }
    }
}
