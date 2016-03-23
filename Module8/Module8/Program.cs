using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        public Person(string FirstName, string LastName, DateTime Birthdate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthdate = Birthdate;
        }
    }

    class Student : Person
    {
        private static int numStudents = 0;
        // 2. Added a Stack<T> of the proper data type, called Grades, inside the Student object.
        public Stack<int> Grades { get; set; }

        public Student(string FirstName, string LastName, DateTime Birthdate)
            : base(FirstName, LastName, Birthdate)
        {
            this.Grades = new Stack<int>(5);
            numStudents++;
        }

        public static int StudentCount() => numStudents;

        public void TakeTest()
        {
            throw new NotImplementedException();
        }
    }

    class Teacher : Person
    {
        public Teacher(string FirstName, string LastName, DateTime Birthdate)
            : base(FirstName, LastName, Birthdate)
        { }

        public void GradeTest()
        {
            throw new NotImplementedException();
        }
    }

    class UProgram
    {
        public string Name { get; set; }
        public string DepartmentHead { get; set; }
        public List<Degree> Degrees { get; set; }

        public UProgram(string Name, string DepartmentHead)
        {
            this.Name = Name;
            this.DepartmentHead = DepartmentHead;
            this.Degrees = new List<Degree>(1);
        }
    }

    class Degree
    {
        public string Name { get; set; }
        public int CreditsRequired { get; set; }
        public List<Course> Courses { get; set; }

        public Degree(string Name, int CreditsRequired)
        {
            this.Name = Name;
            this.CreditsRequired = CreditsRequired;
            this.Courses = new List<Course>(1);
        }
    }

    class Course
    {
        public string Name { get; set; }
        public int Credits { get; set; }
        public int Duration { get; set; }
        // 1. Used a List<T> collection of the proper data type, inside the Course object.
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }

        public Course(string Name, int Credits, int Duration)
        {
            this.Name = Name;
            this.Credits = Credits;
            this.Duration = Duration;
            this.Students = new List<Student>(3);
            this.Teachers = new List<Teacher>(1);
        }

        public void ListStudents()
        {
            // 4. Used a foreach loop to output the first and last name of each Student in the List<T>
            foreach (Student student in this.Students)
            {
                Console.WriteLine($"Student: {student.FirstName} {student.LastName}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create 3 student objects
            Student student1 = new Student("John", "Doe", new DateTime(1984, 5, 7));
            Student student2 = new Student("Bruce", "Wayne", new DateTime(1987, 4, 23));
            Student student3 = new Student("Clark", "Kent", new DateTime(1988, 7, 30));

            // Populate grades stack for each student
            Random grade = new Random();
            for (int i = 0; i < 5; i++)
            {
                student1.Grades.Push(grade.Next(0, 10));
                student2.Grades.Push(grade.Next(0, 10));
                student3.Grades.Push(grade.Next(0, 10));
            }

            // Create teacher object
            Teacher teacher1 = new Teacher("Bart", "Simpson", new DateTime(1980, 9, 25));

            // Create course object
            Course course1 = new Course("Programming with C#", 40, 4);

            // 3. Added 3 Student objects to this List<T> using the List<T> method for adding objects
            course1.Students.Add(student1);
            course1.Students.Add(student2);
            course1.Students.Add(student3);

            // Added Teacher object to this List<T> using the List<T> method for adding objects
            course1.Teachers.Add(teacher1);

            // Create degree object
            Degree degree1 = new Degree("Bachelor of Science", 400);

            // Add course to degree
            degree1.Courses.Add(course1);

            // Create UProgram object
            UProgram program1 = new UProgram("Information Technology", "Homer Simpson");

            // Add degree to UProgram
            program1.Degrees.Add(degree1);

            // Series of Console.WriteLine statements outputting information
            Console.WriteLine($"The {program1.Name} program contains the {program1.Degrees[0].Name} degree\n");
            Console.WriteLine($"The {degree1.Name} degree contains the course {degree1.Courses[0].Name}\n");
            Console.WriteLine($"The {course1.Name} course contains {Student.StudentCount()} student(s)");
            Console.WriteLine($"The list of students of {course1.Name} course");
            course1.ListStudents();
            Console.ReadKey();
        }
    }
}
