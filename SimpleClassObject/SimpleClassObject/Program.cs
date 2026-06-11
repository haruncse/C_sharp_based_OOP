class Program
{
    static void Main(string[] args)
    {
        // Create objects
        //Student s1 = new Student("AAA", 22, "CSE", 75);
        //Student s2 = new Student("BBB", 21, "EEE", 45);
        //Student s3 = new Student("CCC", 23, "BBA", 60);

        //Student s1 = new Student();
        //s1.CheckResult();
        //Student s2 = new Student();
        //Student s3 = new Student();

        //setStudentInfo

        //s1.setStudentInfo("AAA", 22, "CSE", 75);

        // Display info
        //s1.DisplayInfo();
        //s2.DisplayInfo();
        //s3.DisplayInfo();

        // Check results
        //s1.CheckResult();
        //s2.CheckResult();
        //s3.CheckResult();

        // Store in a list
        //List<Student> students = new List<Student> { s1, s2, s3 };

        //// Calculate average age
        //double avgAge = 0;
        //foreach (var s in students) avgAge += s.Age;
        //avgAge /= students.Count;
        //Console.WriteLine($"Average Age: {avgAge}");
        //Console.ReadLine();

        BankAccount bankAccountClassObj = new BankAccount(2000);
        bankAccountClassObj.Deposit(500);
        //Console.WriteLine();
    }
}