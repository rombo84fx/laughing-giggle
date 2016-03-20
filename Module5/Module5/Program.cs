using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Student
    {
        private static int numStudents = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        public Student(string FirstName, string LastName, DateTime Birthdate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthdate = Birthdate;
            numStudents++;
        }

        public static int StudentCount() => numStudents;
    }

    class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        public Teacher(string FirstName, string LastName, DateTime Birthdate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthdate = Birthdate;
        }
    }

    class UProgram
    {
        public string Name { get; set; }
        public string DepartmentHead { get; set; }
        public Degree[] Degrees { get; set; }

        public UProgram(string Name, string DepartmentHead)
        {
            this.Name = Name;
            this.DepartmentHead = DepartmentHead;
            this.Degrees = new Degree[1];
        }
    }

    class Degree
    {
        public string Name { get; set; }
        public int CreditsRequired { get; set; }
        public Course[] Courses { get; set; }

        public Degree(string Name, int CreditsRequired)
        {
            this.Name = Name;
            this.CreditsRequired = CreditsRequired;
            this.Courses = new Course[1];
        }
    }

    class Course
    {
        public string Name { get; set; }
        public int Credits { get; set; }
        public int Duration { get; set; }
        public Student[] Students { get; set; }
        public Teacher[] Teachers { get; set; }

        public Course(string Name, int Credits, int Duration)
        {
            this.Name = Name;
            this.Credits = Credits;
            this.Duration = Duration;
            this.Students = new Student[3];
            this.Teachers = new Teacher[3];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create students array initializing three students
            Student[] students = { new Student("John", "Doe", new DateTime(1984, 5, 7)),
                new Student("Bruce", "Wayne", new DateTime(1987, 4, 23)),
                new Student("Clark", "Kent", new DateTime(1988, 7, 30)) };

            // Create teachers array initializing one teacher
            Teacher[] teachers = { new Teacher("Bart", "Simpson", new DateTime(1980, 9, 25)) };

            // Create courses array initializing one course with students and teachers arrays
            Course[] courses = { new Course("Programming with C#", 40, 4)
                { Students = students, Teachers = teachers } };

            // Create degrees array initializing one degree with courses array
            Degree[] degrees = { new Degree("Bachelor of Science", 400) { Courses = courses } };

            // Create program initializing with degrees array
            UProgram program = new UProgram("Information Technology", "Homer Simpson")
                { Degrees = degrees };

            // Series of Console.WriteLine statements outputting information as per
            // Module Five assignment instructions
            Console.WriteLine($"The {program.Name} program contains the {program.Degrees[0].Name} degree\n");
            Console.WriteLine($"The {degrees[0].Name} degree contains the course {degrees[0].Courses[0].Name}\n");
            Console.WriteLine($"The {courses[0].Name} contains {Student.StudentCount()} student(s)");
            Console.ReadKey();
        }
    }
}
