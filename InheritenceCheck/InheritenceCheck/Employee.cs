using System;
using System.Collections.Generic;
using System.Text;

public class Employee
{
    public string Name { get; set; }
    public void Work()
    {
        Console.WriteLine($"{Name} is working.");
    }
}
