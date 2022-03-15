/*namespace C_Sharp_Notes_101;


// MULTIPLE DELEGATES

// IN C# , a user can invoke multiple delegates within a single program.
// Depending on the delegate name or the type of parameters passed to the delegate, the appropriate delegate is invoked.

public delegate void Calculations(int a, int b);   // creating a delegate.

public delegate void Show_Delegate();   // creating another delegate

public delegate void Calculation2(int x); // creating another delegate.


public class Multiple_Delegates
{
    public static void Square(int num)
    {
        int square = num * num;
        Console.WriteLine($"Square of {num} is {square}");
    }
    
    public static void Cube(int num)
    {
        int cube = num * num * num;
        Console.WriteLine($"Cube of {num} is {cube}");
    }
    public static void Show()
    {
        Console.WriteLine("This is a show method.");
    }
    public static void Addition(int a, int b)
    {
        int result = a + b;
        Console.WriteLine($"The addition of two number is {result}");
    }

    public static void Subtraction(int a, int b)
    {
        int result = a - b;
        Console.WriteLine($"The subtraction of two number is {result}");
    }

    public static void Multiplication(int a, int b)
    {
        int result = a * b;
        Console.WriteLine($"The multiplication of two number is {result}");
    }

    public static void Division(int a, int b)
    {
        int result = a / b;
        Console.WriteLine($"The division of two number is {result}");
    }

    static void Main(string[] args)
    {
        Show_Delegate obj = new Show_Delegate(Show);
        obj.Invoke();
        Calculations obj1 = new Calculations(Addition);
        obj1.Invoke(5,9);

        Calculation2 obj2 = new Calculation2(Square);
        obj2.Invoke(5);
        
        
        obj2 = Cube;
        obj2(5);
        
        /*Calculation2 obj3 = new Calculation2(Cube);
        obj3.Invoke(5);
    }#1#
}*/