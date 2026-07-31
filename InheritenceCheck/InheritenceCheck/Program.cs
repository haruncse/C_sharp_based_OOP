using System;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine(" This is main Class\n");

        //Employee employee = new Employee();
        //employee.Name = "Test";
        //employee.Work();

        Manager mObject = new Manager();
        mObject.Name = "Test";
        mObject.Work();
        mObject.ApproveLeave();


    }
}