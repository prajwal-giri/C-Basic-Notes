/*namespace C_Sharp_Notes_101;
// Delegates meaning in google: A person sent or authorized to represent others, in particular an elected representative,
// sent to a conference.

// Delegate is a type which holds a method's reference in an object.

// It is also called function pointer.

// Delegate is of reference type.

// Delegate signature should be as same as the method signature referencing by a delegate.

// Delegate can point to a parameterized method or non paramaeterized method.

// Delegate has no implementation means no body with{}

// we can use invoke() method with delegates.

// Deleagates are used to encapsulate methods.

// In the .NET Framework, a deletegate points to one or more methods. Once you instaniate the delegate, the corresponding 
// methods invoke.

// Delegates are objects that contain references to methods that need to invoked instead of containing the actual method names.

// Using Delegates , you can call any method which is identified only at runtime.

// A delegate is like having a general method name, that points to various methods at different times and invokes the required method
// at run-time.

// In C# , Invoking a delegate will execute the referenced method at run-time.

// To associate a delegate with a particular method, the method must have the same return type and parameter type as that of delegate.

// It is used to make fast execution and make program run faster.


public delegate void Calculation(int a, int b);

public class Delegates
{
   

    public static void Addition(int a, int b)
    {
        int result = a + b;
        Console.WriteLine($"The addition of two numbers is {result}");
    }

    public static void Subtraction(int a, int b)
    {
        int result = a - b;
        Console.WriteLine($"The subtraction of two numbers is {result}");
    }

    public static void Multiplication(int a, int b)
    {
        int result = a * b;
        Console.WriteLine($"The multiplication of two numbers is {result}");
    }

    public static void Division(int a, int b)
    {
        int result = a / b;
        Console.WriteLine($"The division of two number is {result}");
    }
    
    
    static void Main(string[] args)
    {
        Calculation obj = new Calculation(Addition);  // or Delegates.Addition
        obj.Invoke(20,5);
        // Delegates.Addition(20,4);  it can also be used, but here we are trying to understand delegates.
        Calculation obj1 = new Calculation(Subtraction);  // or Delegates.Addition
        obj1.Invoke(20,5);
        Calculation obj2 = new Calculation(Multiplication);  // or Delegates.Addition
        obj2.Invoke(20,5);
        Calculation obj3 = new Calculation(Division);  // or Delegates.Addition
        obj3.Invoke(20,5);
        
        // Another Method
        
        /*
        obj = Subtraction;
        obj.Invoke(20,10);

        obj = Multiplication;
        obj(2, 3);

        obj = Division;
        obj(9, 3);  
    }#1#
}*/