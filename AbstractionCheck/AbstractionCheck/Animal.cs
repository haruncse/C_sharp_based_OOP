using System;
public abstract class Animal
{
    public abstract void Speak(); // abstract method
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}