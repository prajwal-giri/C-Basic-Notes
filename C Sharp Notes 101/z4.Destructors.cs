/*namespace c_sharp_notes_101;

// not being called 


// destructors //

// a destructor is a special method which has the same name as the class but starts with the ~(tilda sign) before the class name.
// and immediately de-allocates memory of objects that are no longer required.

// destructor cannot be overloaded or inherited.

// destructor cannot be explicitly invoked.

// destructor cannot specify access modifiers and cannot take parameters.

// cannot be used in static class.

class Person
{
    public string name;
    public int age;


    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string Getname()
    {
        return this.name;
    }

    public int Getage()
    {
        return this.age;
    }

    ~Person()
    {
        Console.WriteLine("Destructor has been invoked");
    }
}






public class Destructors
{
    
    // main method //
    static void Main(string[] args)
    {
        Person raju = new Person("raju mishra", 25);
        Console.WriteLine(raju.Getname());
        Console.WriteLine(raju.Getage());
       
       
    }
} */