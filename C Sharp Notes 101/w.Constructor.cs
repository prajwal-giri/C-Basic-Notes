// // A class constructor is a special member function of a class that is executed whenever we create new objects of that class.
// // A constructor has exactly the same name as that of class and it does not have any return type.
//
//
// namespace C_Sharp_Notes_101;
//
//
// Constructor //
// public class Student
// {
//     // Defualt Constructor
//     // A constructor which has not defined any parameters or we can say without any parameters is called default Constructor.
//     // It initializes the same value of every instance of class.
//     
//     
//     /*public Constructor()
//     {
//         Console.WriteLine("Default Constructor Example.");
//     }*/
//     
//     
//     static void Main(string[] args)
//
//     {
//         /*Student MyConstructor = new Student();*/
//         
//     }
// }   
//



// Parameterized Constructor
// A constructor which has at least one parameter is called Parameterized Constructor.
// Using this type of Constructor we can initialize each instance of the class to different values.


/*
namespace C_Sharp_Notes_101;

public class Student
{
    
    
   

    public int StuId;
    public string Name;
    public int Age;

    public Student(int StuId, string Name, int Age)
    {
        this.StuId = StuId;
        this.Name = Name;
        this.Age = Age;
    }

    public int GetId()
    {
        return this.StuId;
    }
    
    public string GetName()
    {
        return this.Name;
    }

    public int GetAge()
    {
        return this.Age;
    }
    
    static void Main(string[] args)

    {
       

        Student Prajwal = new Student(8, "prajwal giri", 28);
        Student Raju = new Student(9, "raju mishra", 30);

        Console.WriteLine(Raju.Age);

    }
*/
/*}   */