/*namespace C_Sharp_Notes_101;

// SINGLE CAST DELEGATES

// Single Cast Delegates point to single method at a time. In this the delegate is assigned to a single
// method at a time. They are derived from System.Delegate class.

public delegate void Calculation(int num1, int num2);

public class Single_Cast_Delegates
{
    public static void Addition(int num1, int num2)
    {
        int result = num1 + num2;
        Console.WriteLine($"Addition result is {result}");
    }
    static void Main(string[] args)
    {
        Calculation obj = new Calculation(Addition);
        obj(5, 7);
        
    }
}*/