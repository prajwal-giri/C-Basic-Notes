/*namespace C_Sharp_Notes_101;


// INHERITANCE //

// The similarity in physical features of a child to that of its parents is deu to the child having inherited these     
// features from its parents.
// Similary, in C#, inheritance allows you to create a class by deriving the common attributes and methods of an existing class.
// Inheritance provides reusability by allowing us to extend an existing class.
// The reason behind OOP programming is to promote the reusability of code and to reduce complexity in code and it is 
// possible using inheritance.

// Parent Class are also called base class or super class.
// Child Class are also called derived class.
class Employee
{
    public int EmpID;
    public string EmpName;
    public int EmpAge;
    public int EmpContactNo;

    public void show()
    {
        Console.WriteLine("This is the method of base class.");
    }
}

class PermanentEmployee : Employee
{
    public int PermanentSalary;
    public int PermanentHours;

}

class VisitingEmployee : Employee
{
    public int VisitingSalary;
    public int VisitingHours;
}



public class Inheritance
{
    static void Main(string[] args)
    {
        PermanentEmployee kaman = new PermanentEmployee();
        kaman.EmpName = "Kaman Khadka";

        VisitingEmployee prajwal = new VisitingEmployee();
        prajwal.EmpName = "Prajwal Giri";

        Console.WriteLine(prajwal.EmpName);
        Console.WriteLine(kaman.EmpName);
        
        prajwal.show();
        kaman.show();
    }
    
}*/