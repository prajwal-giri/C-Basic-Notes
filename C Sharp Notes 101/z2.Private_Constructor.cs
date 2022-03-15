/*
namespace C_Sharp_Notes_101;

// PRIVATE CONSTRUCTOR//

// When a constructor is created with private specifier, it is not possible for other classes to derive from
//  this class,
// neither is it possible to create an instance of this class. They are usually used in classes that contain, static members only.

// Some Key Points are:

// One use of a private Constructor is when we have only static members.

// Once we provide a Constructor that is either private or public or any, the compiler will not add the parameter-less public 
// constructor to the class.

// In the presence of parameterless private constructor you cannot create a default constructor.

// We cannot inherit the class in which we have a private constructor.

// We can have parameters in private Constructor.
class Example
{
    public static string? name;
    public static int age;
    
    private Example()   // creating private constructor.
    {
        
    }

    public static int GetIncrement()
    {
        return ++age;
    }

    public static void GetTime()
    {
        Console.WriteLine(DateTime.Now);
    }
    
}



public class Private_Constructor
{
    static void Main(string[] args)
    {
        Example.name = "prajwal";
        Example.age = 50;
        Example.GetTime();
        Console.WriteLine(Example.GetIncrement());
        Console.WriteLine(Example.name);



    }
}
*/
