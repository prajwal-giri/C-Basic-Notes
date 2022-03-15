namespace C_Sharp_Notes_101;

//DIFFERENCE BETWEEN METHOD HIDING AND METHOD OVERRIDING


// In method Hiding, a base class reference varibale pointing to a child class object, will invoke 
// the hidden method of base class.

// In method Overriding, a base class reference variable pointing to a child class object, will invoke the overridden
// method of the child class.


// METHOD HIDING EXAMPLE

/*class parent
{
    public void show()
    {
        Console.WriteLine("This is a method of PARENT class.");
    }
}

class child : parent
{
    public new void show()
    {
        Console.WriteLine("This is a method of CHILD class.");
    }
}

public class Method_Hiding_VS_Method_Overriding
{
    static void Main(string[] args)
    {
        parent p = new child();
        p.show();
        
    }
}*/
// output will be : This is a method of PARENT class.



// METHOD OVERRIDING EXAMPLE

/*
class Parent
{
    public virtual void Show()
    {
        Console.WriteLine(" This is a method of PARENT class");  
    }
}

class Child : Parent
{
    public override void Show()
    {
        Console.WriteLine("This is a method of CHILD class");
    }
}

public class Method_Hiding_VS_Method_Overriding
{
    static void Main(string[] args)
    {
        Parent p = new Child();
        p.Show();
    }
}

// output will be : This is a method of CHILD class.
*/
