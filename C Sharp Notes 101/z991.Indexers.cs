/*namespace C_Sharp_Notes_101;

// Indexers allow our object to be used just like an array, or we can say we can index the object using[]
// brackets just like an array.

// We can say indexers are special type of properties which adds logic that how can array or list store the values.

// Syntax of indexer resembles to properties.

// We can use all access modifiers with indexers, and also have return types.

// Indexers are the regular members of a class.

// Indexer is created with the help of this keyword(this).

// In C# introduce the new concept is Indexer. This is very useful for some situation. Let us discuss something about Indexer.

// Indexer concept is object act as an array.
// Indexer an object to be indexed in the same way as an array.
// Indexer modifier can be private, public, protected or internal.
// The return type can be any valid C# types.
// Indexers in C# must must have at least one paramenter. Else the compiler will generate a compilation error.
class Employee
{
    private int[] Age = new int[3];

    public int this[int index]
    {
        set
        {
            if (index < Age.Length && index >= 0)
            {
                if (value > 0)
                {
                    Age[index] = value;
                }
                else
                {
                    Console.WriteLine("Age value cannot be zero or in Negative.");
                }
            }
            else
            {
                Console.WriteLine("Index out of Range");
            }
        }
    

        get
        {
        return Age[index];

        }  
        
    }
}



public class Indexers
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp[2] = -8;
        Console.WriteLine(emp[0]);
    }
}*/