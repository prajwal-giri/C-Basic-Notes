/*namespace C_Sharp_Notes_101;

// POLYMORPHISM 

// Polymorphism is one of the four pillars of Object Oriented Programming.
// Polymorphism in C# is a concept by which we can perform a single action by different ways.
// Polymorphism is derived from 2 Greek Words: POLY and MORPHS.
// The word "polly" means many and "morphs" means forms.
// So polymorphism means many forms

// TYPES OF POLYMORPHISM 

// STATIC POLYMORPHISM (COMPILE TIME POLYMORPHISM)    
// DYNAMIC POLYMORPHISM (RUN TIME POLYMORPHISM)


// STATIC POLYMORPHISM (COMPILE TIME POLYMORPHISM)

// The Mechanism of linking a function with an object during compile time is called static polymorphism or early binding.

// It is also called static binding.

// C# provides two techniques to implement static polymorphism. They are :

// METHOD OR FUNCTION OVERLOADING
// OPERATOR OVERLOADING


// METHOD OR FUNCTION OVERLOADING

// You can have mulitple definitions for the same funciton name in the same scope.

// The definition of the function must differ from each other by the types and/or the number of arguments in the arguments list.

// You cannot overload function declarations that differ only by return type.

class Overloading
{
    public void Add(string a, string b)
    {
       
        string c = a + b;
        Console.WriteLine(c);

    }
    public void Add(int a,int b)
    {
       
        int c = a + b;
        Console.WriteLine(c);

    }
}

public class PolyMorphism_and_Method_Overloading
{
    static void Main(string[] args)
    {
        Overloading obj = new Overloading();
        obj.Add("3","2");
    }
}*/