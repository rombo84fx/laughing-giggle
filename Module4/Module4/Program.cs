using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class Program
    {
        struct Student
        {
            public string FirstName;
            public string LastName;
            public DateTime Birthdate;

            public Student(string FirstName, string LastName, DateTime Birthdate)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Birthdate = Birthdate;
            }
        }

        struct Teacher
        {
            public string FirstName;
            public string LastName;
            public DateTime Birthdate;

            public Teacher(string FirstName, string LastName, DateTime Birthdate)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Birthdate = Birthdate;
            }
        }

        struct UProgram
        {
            public string Name;
            public string DepartmentHead;
            public string Degree;

            public UProgram(string Name, string DepartmentHead, string Degree)
            {
                this.Name = Name;
                this.DepartmentHead = DepartmentHead;
                this.Degree = Degree;
            }
        }

        struct Course
        {
            public string Name;
            public int Credits;
            public int Duration;
            public string Teacher;

            public Course(string Name, int Credits, int Duration, string Teacher)
            {
                this.Name = Name;
                this.Credits = Credits;
                this.Duration = Duration;
                this.Teacher = Teacher;
            }
        }
        
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student("John", "Doe", new DateTime(1984, 5, 7));
            Console.WriteLine("Student Information");
            Console.WriteLine($"Student: {students[0].FirstName} {students[0].LastName} was born on {students[0].Birthdate.ToShortDateString()}");
            Console.ReadKey();
        }
    }
}
