/*using System.Threading.Channels;

namespace C_Sharp_Notes_101;*/


// TYPES OF INHERITANCE //

// 1. Single : It is the type in where there is one base class and one derived class.

// 2. Hierarchical :   It is the type of inheritance in which there are mulitple classes derived from one base class.
//                 :   It is used when there is a requirement of one class feature that is needed in multiple class.

// 3. Multi-Level   : 
// 4. Multiple(using interface)
/*class BaseClass
{
    public void show()
    {
        Console.WriteLine("this is show method from BaseClass");
    }
}

class DerivedClass1 : BaseClass
{
    public void show1()
    {
        Console.WriteLine("this is show1 method from DerivedClass1");
    }
}

class DerivedClass2 : BaseClass
{
    public void show2()
    {
        Console.WriteLine("this is show2 method from DerivedClass2");
    }
    
    
}


public class Types_of_Inheritance
{
    static void Main(string[] args)
    {
        DerivedClass1 Derived1obj = new DerivedClass1();  // creating object 
        Derived1obj.show();  // calling parents method
        Derived1obj.show1(); // calling its own method

        DerivedClass2 Derived2obj = new DerivedClass2();  // creating object
        Derived2obj.show();   // calling parents method
        Derived2obj.show2(); // calling its own method
    }
}*/



// 3. Multilevel Inheritance

// When one class is derived from another derived class then this type of inheritance is called multilevel inheritance.

// 4. Multiple(using interface)  : we will study when we study abstractions.


/*lass BaseClass
{
    public void show()
    {
        Console.WriteLine("this is show method from BaseClass");
    }
}

class DerivedClass1 : BaseClass  // inheritance from parent class
{
    public void show1()
    {
        Console.WriteLine("this is show1 method from DerivedClass1");
    }
}

class DerivedClass2 : DerivedClass1   // inheritance from another child class(DerivedClass1) of parent class Baseclass
{
    public void show2()
    {
        Console.WriteLine("this is show2 method from DerivedClass2");
    }
    
    
}


public class Types_of_Inheritance
{
    static void Main(string[] args)
    {
        DerivedClass1 Derived1obj = new DerivedClass1();  // creating object 
        Derived1obj.show();  
        Derived1obj.show1(); 

        DerivedClass2 Derived2obj = new DerivedClass2();  // creating object
        Derived2obj.show();   
        Derived2obj.show2(); 
        Derived2obj.show1(); 
    }
}
*/



