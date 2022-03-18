/*namespace C_Sharp_Notes_101;


// The ref keyword causes arguments to be passed in a method by reference.

// In call by reference , the called method changes the value of the parameters passed to it from the calling method.

// Any changes made to the parameters in the called method will be reflected in the parameters passed from the calling method 
// When control passes back to the calling method.

// It is necessary that both the called method and the calling method must explicitly specify the ref keyword before the required parameters.

// The variables passed by reference from the calling method must be initialized.


// The out keyword is similar to the ref keyword.
// The only difference is that out is used instead of ref keyword.
// Out keyword doesn't require variables to be initialized.

public class Pass_by_Value_and_Reference
{

    
    // creating a method for example for pass by value
    public static void PassByValue(int a)
    {
        a = a + 10;
        Console.WriteLine(a);
        
    }
    
    
    // creating a method for example for pass by reference

    public static void PassByReference(ref int x)
    {
        x = x + 15;
        Console.WriteLine($"Value of x is {x}");
    }
    
    public static void PassByOut(out int y)  // method similar to pass by reference but value is initialized in method , in pass by reference
    // we initialized the data when we call the method.
    {
        y = 20;
        Console.WriteLine($"Value of y is {y}");
    }
    
    
    static void Main(string[] args)
    {
        
        
        int value = 10;
        PassByValue(value);   // 20
        Console.WriteLine(value); // 10


        int value1 = 15;
        PassByReference(ref value1);  // 30
        Console.WriteLine(value1);   // 30

        
        
        int value2;
        PassByOut(out value2); // 20
        Console.WriteLine(value2); // 20

    }
} */