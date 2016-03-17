using System;

namespace Module3
{
    class Program
    {
        // Variables are based on Module One Assignment instructions

        // Student variables
        static string studentFirstName;
        static string studentLastName;
        static DateTime studentBirthdate;
        static string studentAddressLine1;
        static string studentAddressLine2;
        static string studentCity;
        static string studentStateProvince;
        static int studentZipPostal;
        static string studentCountry;

        // Teacher variables
        static string teacherFirstName;
        static string teacherLastName;
        static DateTime teacherBirthdate;
        static string teacherAddressLine1;
        static string teacherAddressLine2;
        static string teacherCity;
        static string teacherStateProvince;
        static int teacherZipPostal;
        static string teacherCountry;

        // UProgram variables
        static string programName;
        static string programDepartmentHead;
        static string programDegrees;

        // Degree variables
        static string degreeName;
        static int degreeCreditsRequired;

        // Course variables
        static string courseName;
        static int courseCredits;
        static int courseDuration;
        static string courseTeacher;

        static void Main(string[] args)
        {
            try
            {
                GetStudentInformation();
                GetTeacherInformation();
                GetProgramInformation();
                GetDegreeInformation();
                GetCourseInformation();
                PrintStudentDetails();
                PrintTeacherInformation();
                PrintProgramInformation();
                PrintDegreeInformation();
                PrintCourseInformation();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name:");
            studentFirstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name:");
            studentLastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthdate:");
            ValidateBirthdate(out studentBirthdate);
            Console.WriteLine("Enter the student's address line 1:");
            studentAddressLine1 = Console.ReadLine();
            Console.WriteLine("Enter the student's address line 2:");
            studentAddressLine2 = Console.ReadLine();
            Console.WriteLine("Enter the student's city:");
            studentCity = Console.ReadLine();
            Console.WriteLine("Enter the student's state/province");
            studentStateProvince = Console.ReadLine();
            Console.WriteLine("Enter the student's zip/postal:");
            studentZipPostal = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student's country:");
            studentCountry = Console.ReadLine();
        }

        static void PrintStudentDetails()
        {
            Console.WriteLine($"Student: {studentFirstName} {studentLastName} was born on: {studentBirthdate.ToShortDateString()}");
            Console.WriteLine($"Address Line 1: {studentAddressLine1}");
            Console.WriteLine($"Address Line 2: {studentAddressLine2}");
            Console.WriteLine($"City: {studentCity}");
            Console.WriteLine($"State/province: {studentStateProvince}");
            Console.WriteLine($"Zip/postal: {studentZipPostal}");
            Console.WriteLine($"Country: {studentCountry}");
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name:");
            teacherFirstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name:");
            teacherLastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birthdate:");
            ValidateBirthdate(out teacherBirthdate);
            Console.WriteLine("Enter the teacher's address line 1:");
            teacherAddressLine1 = Console.ReadLine();
            Console.WriteLine("Enter the teacher's address line 2:");
            teacherAddressLine2 = Console.ReadLine();
            Console.WriteLine("Enter the teacher's city:");
            teacherCity = Console.ReadLine();
            Console.WriteLine("Enter the teacher's state/province");
            teacherStateProvince = Console.ReadLine();
            Console.WriteLine("Enter the teacher's zip/postal:");
            teacherZipPostal = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the teacher's country:");
            teacherCountry = Console.ReadLine();
        }

        static void PrintTeacherInformation()
        {
            Console.WriteLine($"Teacher: {teacherFirstName} {teacherLastName} was born on: {teacherBirthdate.ToShortDateString()}");
            Console.WriteLine($"Address Line 1: {teacherAddressLine1}");
            Console.WriteLine($"Address Line 2: {teacherAddressLine2}");
            Console.WriteLine($"City: {teacherCity}");
            Console.WriteLine($"State/province: {teacherStateProvince}");
            Console.WriteLine($"Zip/postal: {teacherZipPostal}");
            Console.WriteLine($"Country: {teacherCountry}");
        }

        static void GetProgramInformation()
        {
            Console.WriteLine("Enter the program's name:");
            programName = Console.ReadLine();
            Console.WriteLine("Enter the program's department name:");
            programDepartmentHead = Console.ReadLine();
            Console.WriteLine("Enter the program's degrees:");
            programDegrees = Console.ReadLine();
        }

        static void PrintProgramInformation()
        {
            Console.WriteLine($"Program: {programName}");
            Console.WriteLine($"Department name: {programDepartmentHead}");
            Console.WriteLine($"Degrees: {programDegrees}");
        }

        static void GetDegreeInformation()
        {
            Console.WriteLine("Enter the degree's name:");
            degreeName = Console.ReadLine();
            Console.WriteLine("Enter the degree's credits:");
            degreeCreditsRequired = int.Parse(Console.ReadLine());
        }

        static void PrintDegreeInformation()
        {
            Console.WriteLine($"Degree: {degreeName}");
            Console.WriteLine($"Credits required: {degreeCreditsRequired}");
        }

        static void GetCourseInformation()
        {
            Console.WriteLine("Enter the course's name");
            courseName = Console.ReadLine();
            Console.WriteLine("Enter the course's credits:");
            courseCredits = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the course's duration:");
            courseDuration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the course's teacher:");
            courseTeacher = Console.ReadLine();
        }

        static void PrintCourseInformation()
        {
            Console.WriteLine($"Course: {courseName}");
            Console.WriteLine($"Credits: {courseCredits}");
            Console.WriteLine($"Duration: {courseDuration}");
            Console.WriteLine($"Teacher: {courseTeacher}");
        }

        static void ValidateBirthdate(out DateTime birthdate)
        {
            try
            {
                birthdate = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
