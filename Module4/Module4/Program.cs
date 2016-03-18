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
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Enter student {i + 1} first name:");
                students[i].FirstName = Console.ReadLine();
                Console.WriteLine($"Enter student {i + 1} last name:");
                students[i].LastName = Console.ReadLine();
                Console.WriteLine($"Enter student {i + 1} birthdate name:");
                students[i].Birthdate = DateTime.Parse(Console.ReadLine());
            }
            foreach (var student in students)
            {
                Console.WriteLine($"Student: {student.FirstName} {student.LastName} was born on {student.Birthdate.ToShortDateString()}"); 
            }
            Console.ReadKey();
        }
    }
}
