// See https://aka.ms/new-console-template for more information
using System;

namespace SimpleCSharpProgram
{
    class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public string GetGrade()
        {
            if (Score >= 90)
                return "A";
            else if (Score >= 80)
                return "B";
            else if (Score >= 70)
                return "C";
            else if (Score >= 60)
                return "D";
            else
                return "F";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student { Name = "Alice", Score = 95 },
                new Student { Name = "Bob", Score = 78 },
                new Student { Name = "Charlie", Score = 55 }
            };

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name}: {student.GetGrade()}");
            }
        }
    }
}
