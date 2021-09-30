using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student kiaran = new Student("Kiaran", 5, 1, 4.0);

            Course cs101 = new Course("CS 101");

            //Time passes on

            cs101.Teacher = new Teacher("Sierra", "Greg");

        }
    }
}
