using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

public class Student
{
    private string name;
    private int age;

    public Student(string myName,int myAge)
    {
        Console.WriteLine($"This is Student Class Constructor  Name: {myName} Age: {myAge}");
        //Console.WriteLine("Name:"+ myName);
        this.name = myName;
        this.age= myAge;
    }


    ~Student() {
        Console.WriteLine("This is Student Class Destructor");
    }


    // Getter and Setter using properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
                age = value;
            else
                Console.WriteLine("Age must be positive.");
        }
    }

    // Method to display info
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {this.name}, Age: {this.age}");
        Console.WriteLine($"From Setter Getter: Name: {Name}, Age: {Age}");
    }


}
