/*namespace C_Sharp_Notes_101;

// When the derived class overrides a base class method, variable, property or event , then the new method , variable,
// property, or event can be declared as sealed.

// Sealing the new method prevents the method from further overriding.

// An overridden method can be sealed by preceding the override keyword with the sealed keyword.

// STEPS TO REMEMBER FOR SEALED METHODS:

// Sealed method is always an override method of child class.
// We cannot again override the sealed method.
// Sealed Method is only available with Method Overriding.
// Sealed Keyword is not available with the method Hiding.
// Sealed is used together with override method.
// We cannot make normal methods as sealed.

// 

class A
{
    public virtual void Print()
    {
        Console.WriteLine("this is the method of Class A");
    }
}

class B : A
{
    public sealed override void Print()   // as we put sealed on override method we cannot override it below.
    {
        Console.WriteLine("This is the method of class B");
    }
}

class C : B

{
    public override void Print()   // error is showing as we are trying to override the sealed override method.
    {
        Console.WriteLine("This is the method of class C");
    }
}
public class Sealed_Methods
{
    static void Main(string[] args)
    {
        A obj = new C();
        obj.Print();
    }
}*/