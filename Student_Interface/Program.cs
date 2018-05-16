using Student_Interface.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("------------------");
            Console.WriteLine("Enter Full Name:");
            string fullname = Console.ReadLine();
            Student student = new Student(name, fullname);
            student.GetAvgGrade();
            student.GetName();
            student.GetFullName();
            Console.Clear();
            student.ShowInfo();


        }
    }
}
