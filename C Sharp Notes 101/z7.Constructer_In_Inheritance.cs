using System.Threading.Channels;

namespace C_Sharp_Notes_101;


// A constructor is a method with the same name as the class name and is invoked automatically when a new instance of a
// class is created.

// Constructor of both classes must be executed when the object of child class is created.

// Sub(child/derived) Class's constructor invokes constructor of super(parent) class.

// Explicit call to the super class constructor from sub class's can be made using base().

// base() should be the first statement of child class constructor.

// if we dont write base() explicitly then compiler implicitly write the base().

/*
class BaseClass
{
    public BaseClass()
    {
        Console.WriteLine("running from base class constructor");
    }
}

class DerivedClass: BaseClass
{
    public DerivedClass()      // public DerivedClass : base()   by default.
    {
        Console.WriteLine("running from derived class constructor");
    }
}



public class Constructer_In_Inheritance
{
    static void Main(string[] args)
    {
        
        DerivedClass dobj = new DerivedClass();
    }
}
*/



/*class BaseClass1
{
    public BaseClass1(string message)
    {
        Console.WriteLine(message);
    }
}

class DerivedClass1: BaseClass1
{
    public DerivedClass1() :base("This is message of parameter of parent constructor ")     // public DerivedClass : base()   by default.
    {
        Console.WriteLine("running from derived class constructor");
    }
}



public class constructer_In_Inheritance
{
    static void Main(string[] args)
    {
        
        DerivedClass1 dobj = new DerivedClass1();
    }
}*/