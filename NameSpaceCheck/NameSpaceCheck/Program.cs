using System;
// Import the namespace
using University;
class Program
{
    static void Main(string[] args)
    {
        // Create objects from University namespace
        Student s1 = new Student { Name = "Harun", Age = 22 };
        Teacher t1 = new Teacher { Name = "Ripa", Subject = "Math" };
        s1.DisplayInfo();
        t1.DisplayInfo();
        Console.ReadLine();
    }
}
