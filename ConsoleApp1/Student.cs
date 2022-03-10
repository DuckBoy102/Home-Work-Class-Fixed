using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private string fullname;

        public string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private float grade;

        public float Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public Student(string Name, int ID, int Grade)
        {
            this.FullName = Name;
            this.ID = ID;
            this.Grade = Grade;
        }
        public void CalculateAverage()
        {
            int a, b, c, d, e;
            Console.WriteLine("Enter 5 grades of the student");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            grade = (a + b + c + d + e) / 5;
        }
    }
}
