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
            Console.WriteLine("Enter the first student's name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the first student's ID");
            int ID = int.Parse(Console.ReadLine());
            Student FirstStudent = new Student(name, ID, -1);
            FirstStudent.CalculateAverage();
            Console.WriteLine("The first student's average grade is {0}", FirstStudent.Grade);
            Console.WriteLine("Enter the second student's name");
            string secondname = Console.ReadLine();
            Console.WriteLine("Enter the second student's ID");
            int secondID = int.Parse(Console.ReadLine());
            Student SecondStudent = new Student(secondname, secondID, -1);
            SecondStudent.CalculateAverage();
            Console.WriteLine("The second student's average grade is {0}", SecondStudent.Grade);
            Console.WriteLine("Enter the thired student's name");
            string thiredname = Console.ReadLine();
            Console.WriteLine("Enter the thired student's ID");
            int thiredID = int.Parse(Console.ReadLine());
            Student ThiredStudent = new Student(thiredname, thiredID, -1);
            ThiredStudent.CalculateAverage();
            Console.WriteLine("The thired student's average grade is {0}", ThiredStudent.Grade);
        }
    }
}
