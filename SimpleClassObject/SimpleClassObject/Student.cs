using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System;
public class Student
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
    public double Grade { get; set; }

    // Constructor
    //public Student(string name, int age, string department, double grade)
    //{
    //    Name = name;
    //    Age = age;
    //    Department = department;
    //    Grade = grade;
    //}

    public void setStudentInfo(string name, int age, string department, double grade)
    {
        Name = name;
        Age = age;
        Department = department;
        Grade = grade;
    }

    // Method to display info
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Department: {Department}, Grade: {Grade}");
    }

    // Method to check pass/fail
    public void CheckResult()
    {
        if (Grade >= 50)
            Console.WriteLine($"{Name} has passed.");
        else
            Console.WriteLine($"{Name} has failed.");
    }
}
