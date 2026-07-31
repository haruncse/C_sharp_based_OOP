using System;


public class Program
{
    static void Main()
    {
        Dog d1 = new Dog();
        d1.Speak(); // implemented in Dog
        d1.Eat(); // inherited from Animal
    }
}
