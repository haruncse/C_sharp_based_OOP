class Program
{
    static void Main(string[] args)
    {
        // Base class reference pointing to derived objects
        Shape s1 = new Circle();
        Shape s2 = new Rectangle();
        s1.Draw(); // Calls Circle's Draw
        s2.Draw(); // Calls Rectangle's Draw
        Console.ReadLine();
        Calculator c= new Calculator();
        Console.WriteLine(c.Add(20.00,40.00));
        Console.WriteLine(c.Add(20, 40,80));
    }
}
