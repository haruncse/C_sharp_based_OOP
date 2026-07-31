using System;
public class Calculator
{
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
    public float Add(float a, float b, float c)
    {
        float d = a + b + c;
        return d;
    }

    public int Add(int a, int b, int c) => a + b + c;
    public int Add(int a, float b, double c)
    {
        return a;
    }

}
