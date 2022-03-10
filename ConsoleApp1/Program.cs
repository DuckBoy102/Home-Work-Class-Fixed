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
            Console.WriteLine("Enter the student's ID");
            int ID = int.Parse(Console.ReadLine());
            Student FirstStudent = new Student(name, ID, 0);
            Console.WriteLine("Enter the second student's name");
            string secondname = Console.ReadLine();
            Console.WriteLine("Enter the second student's ID");
            int secondID = int.Parse(Console.ReadLine());
            Student SecondStudent = new Student(secondname, secondID, 5);
            Console.WriteLine("Enter the thired student's name");
            string thiredname = Console.ReadLine();
            Console.WriteLine("Enter the thired student's ID");
            int thiredID = int.Parse(Console.ReadLine());
            Student ThiredStudent = new Student(thiredname, thiredID, 10);
        }
    }
}
