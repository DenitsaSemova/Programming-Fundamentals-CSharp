using System;

namespace P00LabObjectsAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Pesho", 19); //{Name = "Pesho", Age = 19 }; 

            //student.Name = "Pesho";
            //student.Age = 19;

            Console.WriteLine(student.Name);
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

    }
}
