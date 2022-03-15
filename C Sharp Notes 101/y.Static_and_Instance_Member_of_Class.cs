

/*
namespace C_Sharp_Notes_101;

// Static_and_Instance_Member_of_Class

// Instance Member

// Instance member have a separate copy for each and every object of the class.
// Instance member belongs to the objects of the class.
// When no static keyword is present in the class member is called instance member or non-static.
// Instance or non-static members are invoked using objects of the class.

class Student
{
    
    // creating instance members
    public int RollNo;
    public string? FirstName;
    public string? LastName;
    public int Standard;

    public void PrintFullName()     // creating instance method

    {
        string fullName = this.FirstName +" " + this.LastName;
        Console.WriteLine(fullName);
    }
}


public class Static_and_Instance_Member_of_Class
{
    static void Main(string[] args)
    {
        // Instance fields/variables access is only available by creating a Class.//
        Student prajwal = new(); // creating object
        prajwal.FirstName = "Prajwal";
        prajwal.LastName = "giri";
        prajwal.Standard = 12;
        prajwal.RollNo = 48;
        // instance methods access is only available by creating a Class//
        prajwal.PrintFullName();

        Student sujata = new Student(); // creating second object
        sujata.FirstName = "Suajta";
        sujata.LastName = "Tamang";
        sujata.Standard = 11;
        sujata.RollNo = 54;
        sujata.PrintFullName();

        Console.WriteLine($"{prajwal.FirstName} {prajwal.LastName} {prajwal.RollNo}");

        Console.WriteLine($"{sujata.FirstName} {sujata.LastName} {sujata.RollNo}");

    } 
}

// STATIC MEMBERS
*/

// Static member belongs to the class.
// We can define class members as static using the static keyword.
// when we declare a member of a class as static, it means no matter how many objects of the class are created, there is only one copy 
// of the static member.

// Static variables are used for defining constants because their values can be retrieved by invoking the class without creating 
// the instance/object of it.

// Static variables can be initialized outside the member function or class definition.

// We can also initialize static variables inside the class function.
// We can also declare a member function as static.
// Such functions can access only static variables.
// Static member are invoked using class name.



/*
namespace C_Sharp_Notes_101;



class Student
{
    
    // creating instance members
    public string? FullName;    // instance variable
    public static int Standard;      // static variable.
    public static int Fees = 8000;

    public void PrintFullName()     // creating instance method

    {
        string? fullName = this.FullName;
        Console.WriteLine(fullName);
        Console.WriteLine(Fees);
    }

    public static int GetFees()
    {
        return Fees;
    }

    public static int GetFeesPerYear(int fee)
    {
        return fee / 10;
    }
}


public class Static_and_Instance_Member_of_Class
{
    static void Main(string[] args)
    {
        // Instance variables access is only available by creating a Class.//
        Student prajwal = new(); // creating object
        prajwal.FullName = "Prajwal Giri";
    
        // instance methods access is only available by creating a Class//
        prajwal.PrintFullName();
         // creating second object

        Student.Standard = 12;

        Student.GetFees();
        Student.GetFeesPerYear(6000);



    } 
}
*/






