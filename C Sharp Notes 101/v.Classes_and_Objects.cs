
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace C_Sharp_Notes_101;

// C# Programs are composed of classes that represents the entities(objects) of the program which also include code to instantiate the classes 
// as objects.

// Classes and objects are reference data types.

// When the program runs, objects are created for the classes and they may interact with each other to provide the functionalities of 
// the program

// An object is a tangible entity such as a car, a table, or a briefcase.
// Every object has some characteristics and is capable of performing certain actions.

// The concept of objects in the real world can also be extended to the programming world. An object in a programming langauges 
// has a unique , state, and behaviour.

// The state of the object refers to its characteristics or attributes. 


public class Classes_and_Objects
{
    private string name;
    private string address;
    private int age;


    private void SetStudent(string fullname, string fulladdress, int fullage)
    {
        this.name = fullname;
        this.address = fulladdress;
        this.age = fullage;
    }

    private void GetStudent()
    {
        Console.WriteLine($"Your name is {this.name}");
        Console.WriteLine($"Your address is {this.address}");
        Console.WriteLine($"Your age is {this.age}");
    }
    static void Main(string[] args)
    {
        Classes_and_Objects ravi = new Classes_and_Objects();
        ravi.SetStudent("Ravi Ghimire","kathmandu",17);
        ravi.GetStudent();

        Console.WriteLine("Enter your name ");
        string name = Console.ReadLine();
 
        Console.WriteLine("enter your address");
        string address = Console.ReadLine();
        
        Console.WriteLine("Enter your age");
        int age = int.Parse(Console.ReadLine());

        Classes_and_Objects obj = new Classes_and_Objects();
        obj.SetStudent(name,address,age);
        obj.GetStudent();

    }
}