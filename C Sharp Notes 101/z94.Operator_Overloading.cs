/*using System.Text.RegularExpressions;

namespace C_Sharp_Notes_101;
// Operator Overloading Concepts falls on polyphormism

// OPERATOR OVERLOADING

// The concept of overloading a function can also be applied to operators.
// Operator overloading gives the ability to use the same operator to do various operations.


// With + operator we can add integer
// With + operator we can concatenate string
// With + operator we can combine objects of same class.


// first we need to create a static method and also include operator followed by its symbol.

// It provides additional capabilities to C# operators when they are applied to user-defined data types.

// It enables to make user-defined implementations of various operations where one or both of the operands of a user-defined datatypes.

// Only the predefined set of C# operators can be overloaded.

// To make operations on a user-defined data type is not as simple as the operations on a built-in data type.

// To use operators with user-defined data types , they need to be overloaded according to a programmer's requirement.

// An operator can be overloaded by defining a function to it.

// The function of the operator  is declared by using the operator keyword.

// Operators may be considered as functions internal to the compiler.

//  +,-,!, ~, ++, --,   unary operator take one operand and can be overloaded.

// +,-,*, /, % Binary operators take two operands and can be overloaded

// == ,!=, =  Comparision operator can be overloaded.

// &&, || Logical operators cannot be overloaded directly.

// +=, -+, *=, /= , %=   Assignment operators cannot be overloaded.



class Student
{
    public string Name;
    public int num;

    public static Student operator +(Student Prajwal, Student Raju)
    {
        Student Group4 = new Student();
        Group4.Name = Prajwal.Name + " " +  Raju.Name;
        Group4.num = Prajwal.num + Raju.num;
        return Group4;
    }
}
public class Operator_Overloading
{
    static void Main(string[] args)
    {
        Student Raju = new Student();
        Raju.Name = "Raju";
        Raju.num = 18;

        Student Prajwal = new Student();
        Prajwal.Name = "Prajwal";
        Prajwal.num = 17;

        Student Group4 = new Student();
        Group4 = Prajwal + Raju;

        Console.WriteLine(Group4.Name);
        Console.WriteLine(Group4.num);
    }

}*/