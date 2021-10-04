﻿using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        private readonly int studentId;
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int sId, int numberOfCredits, double gpa)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int sId)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public Student(string name)
        {
            Name = name;
            studentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public string StudentInfo()
        {
            return (Name + " has a GPA of: " + Gpa);
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // update fields
            double currentTQS = Gpa * NumberOfCredits;


        }

        public string GetGradeLevel (int NumberOfCredits)
        {
            //Freshman (0-29 credits), Sophomore (30-59 credits), Junior (60-89 credits), or Senior (90+ credits)
            if (NumberOfCredits <= 29)
                {
                    return "Freshman";
                }
                else if (NumberOfCredits >= 30 && NumberOfCredits <= 59)
                { 
                    return "Sophmore";
                }
                else if (NumberOfCredits >= 60 && NumberOfCredits <= 89)
                {
                    return "Junior";
                }
                else 
                {
                    return "Senior";
                }
        }

    }
}

