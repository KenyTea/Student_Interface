using Student_Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Interface.Class
{

    public class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        private Random r = new Random();

        public Student(string name, string fullname)
        {
            Name = name;
            FullName = fullname;
            Grades = new int[r.Next(1, 6)];
            for (int i = 0; i < Grades.Length; i++)
            {
                Grades[i] = r.Next(1, 12);
            }
        }

        public double GetAvgGrade()
        {
            int score = 0;
            for (int i = 0; i < Grades.Length; i++)
            {
                score += Grades[i];
            }
            return (double)(score / Grades.Length);
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetName()
        {
           return Name;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name - " + GetName());
            Console.WriteLine("Full Name - " + GetFullName());
            Console.WriteLine("Avg Grade - " + GetAvgGrade());
        }
    }
}
