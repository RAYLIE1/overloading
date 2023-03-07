using System;

class OverloadDemo
{
    public void Print(int value)
    {
        Console.WriteLine($"Printing integer value: {value}");
    }

    public void Print(double value)
    {
        Console.WriteLine($"Printing double value: {value}");
    }

    public void Print(string value)
    {
        Console.WriteLine($"Printing string value: {value}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        OverloadDemo demo = new OverloadDemo();

        demo.Print(5);           // calls the integer Print method
        demo.Print(3.14);        // calls the double Print method
        demo.Print("hello");     // calls the string Print method
    }
}
