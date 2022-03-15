namespace C_Sharp_Notes_101;

// SEALED CLASS

// A Sealed class is a class that prevents inheritance.

// Features of Sealed Class.

// A sealed class can be declared by preceding the class keyword with the sealed keyword.

// The sealed keyword prevents a class from being inherited by any other class.

// The sealed class cannot be a base class as it cannot be inherited by any other class. If a class tries to derive a sealed class,
// C# compiler generates an error.

// PURPOSE OF SEALED CLASS

// Consider a class named SystemInformation that consists of critical methods that affect the working of the operating system.

// You might not want any third party to inherit the class SystemInformation and override its methods, thus, causing security 
// and copyright issues.

// Here, you can declare the SystemInformation class as sealed to prevent any change in its variables and methods.


/*sealed class BaseClass
{
    public void Show()
    {
        Console.WriteLine("This is a method of BaseClass");
    }
}

public class Sealed_Class
{
    
}*/