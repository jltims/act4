using System;
using System.Linq;

namespace Act4
{
    class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public int Grade { get; set; }
            public int Age { get; set; }

            public Student(string name, int grade, int age)
            {
                Name = name;
                Grade = grade;
                Age = age;
            }
        }

        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            students[0] = new Student("Mae", 80, 18);
            students[1] = new Student("Mei", 61, 16);
            students[2] = new Student("Mie", 92, 18);
            students[3] = new Student("Mouew", 100, 21);
            students[4] = new Student("Moupe", 91, 16);

            var filteredStudents = from student in students
                                   where student.Grade > 75
                                   select student;

            foreach (var student in filteredStudents)
            {
                if (student.Grade == 100)
                {
                    Console.WriteLine(student.Name + " with Highest Honors");
                }

                if (student.Grade < 100 && student.Grade >= 90)
                {
                    Console.WriteLine(student.Name + " with High Honors");
                }
            }

            Console.ReadKey();
        }
    }
}
