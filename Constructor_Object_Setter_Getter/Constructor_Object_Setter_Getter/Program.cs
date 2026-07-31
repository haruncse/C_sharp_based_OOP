using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" This is main Class\n");

        Student student = new Student("Student of 64 Batch",4);
        Console.ReadLine();
        student.Name = "New Name";
        student.Age = 25;
        student.DisplayInfo();
    }
}