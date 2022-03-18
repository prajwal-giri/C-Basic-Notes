namespace C_Sharp_Notes_101;

 
// VAR was introduced in C# 3.0
// VAR Keyword is used to store any type of data in its variable.
// Value of Var is decided at the compile time.
// We have the initialize the variable with var keyword.
// If we want to check the type of value stored in var variable then we can use GetType() Method with the Var Variable.
// When we initialize the Var variable with some value then we cannot change the value of Var Variable with some other data type value.
// We can used all the methods of particular type value which is stored in Var Variable.
// Intellisense help is available for the var type of variables. This is because, its type is inferred by the compiler from the type of value,
// it is assigned and as a result, the compiler has all the information related to the type.
// var variables cannot be used for property
// var variables cannot be used for return values from a function.
// They can only be used as local variable in a function.
// We cannot use Var variable as the method paramter.
// Var Keyword is of Value Type.



// Dynamic Keyword.

// Dynamic was introduced in C# 4.0
// Dynamic Keyword is also used to store any type of data in its variable.
// Value of VAR variable is decided at Run Time.
// Initialization is not mandatroy when we declare a variable with Dynamic Keyword.
// If we want to check the type of value which is stored in Dynamic variable then we can use GetType() Method with the Dynamic variable.
// When we initialize the Dynamic Variable with Some value then we can change the value of Dynamic Variable with some other data type Value.
// Intellisense Help is not available for Dya=namic Type of Variables since thier type is unknown until Run Time. So, Intellisense Help is not available.
// Dynamic variables can be used to create properties and return values from a function.
// Dynamic variables can be used in parameters.
// Dynamic keyword is of Reference types.

 




public class Var_and_Dyanamic_Keyboard
{
    public static dynamic show(dynamic  a)
    {
        return a;
        Console.WriteLine(a);
    }
    static void Main(string[] args)
    {
        var a = 3;
        Console.WriteLine(a.GetType());

        int b = 5;
        Console.WriteLine(b.GetType());

        var name = "Prajwal";
        Console.WriteLine();

        dynamic x = 10;
        Console.WriteLine(x.GetType());

        dynamic School;
        School = "Green";
        School = 5;



    }
    
    
}