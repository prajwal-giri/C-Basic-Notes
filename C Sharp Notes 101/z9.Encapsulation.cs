/*
namespace C_Sharp_Notes_101;

// Encapsulation is one of the four fundamental OOP concepts. The other 3 are inheritance,polymorphism and abstraction.
// Encapsulation in C# is a mechanism of wrapping the data(variables) and code acting on the data(methods or properties) together as a single unit.
// In encapsulation, the variables of a class will be hidden from other classes and can be accessed only through methods or properties of
// their current class. 


// In a different way, encapsulation is a protective shield that prevents the data from being accessed by the code outside of this shield.
// Encapsulation is the procedure of encapsulating data and functions into a single unit.(called class).


// To achieve Encapsulation in C#.

// * Declare the variables of a class as private.
// * Provide public setter and getter methods or properties to modify and view the variables values.


// Benefits of Encapsulation

// The fields of a class can be made read-only and write-only.
// A class can have total control over what is stored in its fields.


// Why do we need Encapsulation

// The need of encapsulation is to protect or prevent the code(data) from accidental corruption due to the silly little errors that we are all
// prone to make.

class Person
{
    private string _name;
    private int _age;
    
    
    public void SetName(string name)
    {
        if (string.IsNullOrEmpty(name) == true)
        {
            Console.WriteLine("Name is required");
            return;
        }
        this._name = name;
    }

    public void GetName()
    {
        if (string.IsNullOrEmpty(this._name) == false)
        {
            Console.WriteLine($"Your Name is {this._name}");
        }
        
    }

    public void SetAge(int age)
    {
        if (age > 0)
        {
            this._age = age;
            return;
        }

        Console.WriteLine("Age should not be 0 or negative.");
        
        
    }

    public void GetAge()
    {
        if (this._age > 0)
        {
            Console.WriteLine($"Your age is {this._age}");
            return;
        }
    }
}


public class Encapsulation

{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.SetName("p");
        p1.GetName();
        p1.SetAge(-28);
        p1.GetAge();
    }
}
*/
