using System;
using System.Collections.Generic;
using System.Text;

public class Manager : Employee
{
    public void ApproveLeave()
    {
        Console.WriteLine($"{Name} approved leave.");
    }
}