using System;
namespace University
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Subject { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Teacher: {Name}, Subject: {Subject}");
        }
    }
}