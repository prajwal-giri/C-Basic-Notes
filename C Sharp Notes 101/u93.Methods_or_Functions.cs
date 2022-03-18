/*

namespace C_Sharp_Notes_101;

// A method is a group of statements that work together.
// Methods are functions declared in a class and may be used to perform operations on class variables.
// They are blocks of code that can take parameters and may or may not return a value.
// It is used to perform specific task.
// Methods are reusable.
// Every C# program has at least one class with a method named Main.


// INVOKING METHODS: 

// To use a method, we need to define the method and call the method.

// A method can be invoked in a class by creating an object of the class where the object name is followed by period (.) and the name of the method followed by parentheses.

// In C# , a method is always invoked from another method.

// This is referred to as the calling method and the invoked method is referred to as the called method.


public class Methods_or_Functions
{

    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
        
    }

    public static void Show_Name_Age(string name, int age)
    {
        Console.WriteLine($"{name} is {age} years old.");
    }

    *//*
    public static void Show2(string name = "Unknown")  // Default Argument.
    {
        Console.WriteLine($"Hello {name},Welcome to C Sharp Programming");
    }
    *//*
    
    
    // public void Show()   // Declaring the method. (non-static or instance Method)  //non parameterized method.
    // {
    //     Console.WriteLine("Show Method Running");
    //     Console.WriteLine("Learning Instance Method.");
    // }
    //
    // public static void Welcome() // Declaring static method // non parameterized method.
    // {
    //     Console.WriteLine("Show static method running");
    //     Console.WriteLine("Learning Static Method.");
    // }
    //

    *//*public static void  Add(int a, int b)   // called parameters/.
    {
        int sum = a + b;
        Console.WriteLine($"The sum of two number is {sum}");
    }
    *//*
    
    
    
    static void Main(string[] args)
    {
        Show_Name_Age(age:15,name:"Prajwal");  // named arguments.
        Methods_or_Functions.Sum(10, 25);


        // Methods_or_Functions obj = new Methods_or_Functions();   // creating object and using constructor.
        // obj.Show(); // calling the method.
        //
        //
        // Welcome();   // calling static method.
        // Methods_or_Functions.Welcome(); // Only used using Class Name.Method if it is on another class.



        *//*
        Console.WriteLine("Enter first number");
        int first_num = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second Number");
        int second_num = int.Parse(Console.ReadLine());
        
        Methods_or_Functions.Add(first_num,second_num);*//*

        // Methods_or_Functions.Add(2,5);
        // Methods_or_Functions.Add(30, 40); // data inside called arguments.


    }
}

*/