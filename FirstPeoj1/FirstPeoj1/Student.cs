using System;
using System.Collections.Generic;
using System.Text;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
    public double Grade { get; set; }

    //public Student(string name, int age, string department, double grade) { 
    //    Name = name;
    //    Age = age;
    //    Department = department;
    //    Grade = grade;
    //}

    public void DisplayInfo()
    {
        Console.WriteLine("This is from Student Class Display function.");
        Name = "64 B";

    }

}

