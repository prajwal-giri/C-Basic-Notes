/*namespace C_Sharp_Notes_101;


// COPY CONSTRUCTOR IN C# 

// The constructor which creates an object by copying varibales from another object is called a copy constructor.
// The purpose of a copy constructor is to initialize a new instance to the values of an existing instance.

// In C# , Copy Constructor is a parametrized constructor which contains a parameter of same class type.
// The copy constructor in C# is useful whenever we want to initialize a new instance to the values of an existing instance.

// In simple words, we can say copy constructor is a constructor which copies a data of one object into another object.

class Example
{
    private string name;
    private int age;

    public Example(string name, int age)   // instance constructor
    {
        this.name = name;
        this.age = age;
    }

    public Example(Example x)   // copy constructor
    {
        this.name = x.name;
        this.age = x.age;
        Console.WriteLine("New data");

    }

    public void getData()    // instance method
    {
        Console.WriteLine($"Name is {this.name}");
        Console.WriteLine($"Age is {this.age}");
    }
}



// main method //
public class Copy_Constructor
{
    static void Main(string[] args)
    {
        Example obj1 = new Example("prajwal",30);
        obj1.getData();
        Example obj2 = new Example(obj1);
        obj2.getData();
    }
}*/