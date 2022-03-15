/*namespace C_Sharp_Notes_101;

// DYANAMIC OR RUNTIME POLYMORPHISM

// Run time polymorphism is achieved by method overriding.
// Method overriding allows us to have virtual and abstract methods in the base using derived classes with the same name, 
// and the same parameter.



// METHOD OVERRIDING

// If derived class defines same method as defined in its base class, it is known as method overriding in C#.

// It is used to achieve runtime polymorphism

// It enables you to provide specific implementation of the method in child class which is already provided by its base toclass.

// To perform method overriding in C# , you need to use virtual keyword with base class method and override keyword with child class method.

// A method declared using the virtual keyword is referred as virtual method. 

// In the derived class, you need to declare the inherited virtual method using the override keyword.

// In the derived class, you need to declare the inherited virtual method using the override keyword which is mandatory for any virtual 
// method that is inherited in the derived class.

// The override keyword overrides the base class method in the derived class.
class Parent
{
    public virtual void Print()
    {
        Console.WriteLine("This is a method of PARENT class.");
    }

}

class Child : Parent
{
    public override void Print()
    {
        Console.WriteLine("This is a method of CHILD Class.");
    }
}

public class Method_Overriding_Dyanamic_Runtime_Polymorphism_
{
    static void Main(string[] args)
    {
        Parent p = new Child();
        p.Print();
    }
}*/