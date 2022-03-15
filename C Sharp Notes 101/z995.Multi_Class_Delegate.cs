/*namespace C_Sharp_Notes_101;

// MULTI CAST DELEGATE

// When a delegate is wrapped with more than one method that is known as a multicast delegate.
// IN C# , delegates are multicast, which means that they can point to more than one function at a time.
// They are derived from System.MulticastDelegate class.

// We can use+= and -= assignment operators to implement multi cast delegates.


public delegate void Calculations(int a, int b);
public class Multi_Class_Delegate
{
    public static void Addition(int a, int b)
    {
        int result = a + b;
        Console.WriteLine($"The addition result is {result}");
    }

    public static void Subtraction(int a, int b)
    {
        int result = a - b;
        Console.WriteLine($"The subtraction result is {result}");
    }

    public static void Multiplication(int a, int b)
    {
        int result = a * b;
        Console.WriteLine($"The Multiplication result is {result}");
    }

    public static void Division(int a, int b)
    {
        int result = a / b;
        Console.WriteLine($"The division result is {result}");
    }
    
    // main method //
    static void Main(string[] args)
    {
        Calculations obj = new Calculations(Addition);
        obj += Subtraction;
        obj += Multiplication;
        obj -= Division;   // it excludes division as there is -=.  
        obj(10, 5);
    }
}*/