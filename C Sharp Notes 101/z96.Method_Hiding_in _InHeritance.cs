/*using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace C_Sharp_Notes_101;

// Method hiding occurs in inheritance relationship when base class and derived class both have a method with same name.
// and same signature.

// When we create the object of the derived class it will hide the base class method and will call its own method and this 
//is called  method hiding or name hiding in C# inheritance.

// We use "new" keyword in derived function name to show that implementation of the function in derived class is intentional 
// and derived class no longer want to use base class method.

// Note: if we dont use "new" keyword then compiler will raise only warning, but program will work fine.


// DIFFERENT WAYS TO CALL A HIDDEN BASE CLASS MEMBER FROM DERIVED CLASS 

// 1. USE BASE KEYWORD
// 2. CAST CHILD TYPE TO PARENT TYPE AND INVOKE THE HIDDEN MEMBER.
// 3. ParentClass PC = new ChildClass();
//     PC.hiddenMethod();

/*class Parent
    {
        public void show()
        {
            Console.WriteLine("this is parent method");
        }
    }

class Child:Parent
{
    public new void show()
    {
        /*Console.WriteLine("this is child method");#2#
        
        base.show();  // to call base method.
    }
}#1#


/*public class Method_Hiding_in__InHeritance
    { 
        static void Main(string[] args)
        {
            Child child1 = new Child();

            /*((Parent) child1).show();#2#   // this is also a way to call base class method.(converting into parent class)
            child1.show();
            
            
            // another method//

            Parent p = new Child();   // creating reference varibale from base class and object varibale from child class.
            p.show();   // parent class method is being called.
        }
    }#1#
// Parent class can have the reference of its child class.


// When we create the object of child class , parent class object is also created.









// Another Example





/*class Employee
{
    public string firstName;
    public string lastName;
    
    
    public void PrintName()
    {
        Console.WriteLine(firstName+ " " + lastName);
    }
}

class PartTimeEmployee: Employee
{
    public new void PrintName()
    {
        Console.WriteLine(firstName+ " " + lastName + " Part Time");
    }
}

class FullTimeEmployee: Employee
{
    public void PrintName()
    {
        Console.WriteLine(firstName+ " " + lastName + " Full Time");
    }
}


class Program
{
    static void Main(string[] args)
    {
        PartTimeEmployee Pte = new PartTimeEmployee();
        Pte.firstName = "Prajwal";
        Pte.lastName = "Giri";
        Pte.PrintName();#1#
    }
}*/