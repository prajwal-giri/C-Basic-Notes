/*namespace C_Sharp_Notes_101;

// static Constructor //

// A static Constructor is used to initialize static varibales of the class and to perform a particular action only once.

// Static Constructor is called only once, no matter how many objects you create.

// Static Constructor is called before instance (defualt or parameterized) Constructor.

// A Static constructor does not take any parameters and does not use any access modifiers.

//Key Points//

// Only one static constructor can be created in the class.
// It is called automatically before the first instance of the class created.
// We cannot call static constructor directly.

class Person
{
    public static string PersonName;
    public static int PersonAge;

    static Person()           // static constructor
    {
        PersonName = "Prajwal";
        PersonAge = 30;
        Console.WriteLine($"Static Constructor running successfully with name {PersonName} and age {PersonAge}");
    }

    public Person()         // instance constructor
    {
        Console.WriteLine("Default Constructor Instance Type");
    }
    
    public static void GetDetails()
    {
        Console.WriteLine($"with name {PersonName} and age {PersonAge}");
    }
}




public class Program
{
   
    static void Main(string[] args)
    {
        Person Prajwal = new Person();
        Person Sujata = new Person();
        Person.GetDetails();
    }
}*/