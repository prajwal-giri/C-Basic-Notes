
//Declaring more than one constructor in a class is called constructor overloading.
//The process of overloading constructors is similar to overloading methods where every constructor has a signature similar to that of a method.
//Multiple constructors in a class can be declared wherein each constructor will have different signatures.
//Constructor overloading is used when different objects of the class might want to use different initialized values.
//Overloaded constructors reduce the task of assigning different values to member variables each time when needed by different objects of the class.


/*namespace C_Sharp_Notes_101
{

// Constructor Overloading //
    public class Employee
    {
        // first constructor //
        public Employee()
        {
            Console.WriteLine("No argument Constructor");
        }

        // second constructor //
        public Employee(int age, string name)
        {
            Console.WriteLine($"{name} is {age} years old.");
        }

        // third constructor //
        public Employee(string firstName, string lastname)
        {
            Console.WriteLine($"Your full name is {firstName} {lastname}");
        }

        // fourth constructor 
        public Employee(int ages, string fullname, string address,int empId)
        {
            Console.WriteLine($"{fullname} of {ages} years old with employee id {empId} lives in {address}");
        }
        // main Method
        static void Main(string[] args)
        {
            Employee Employee1 = new Employee();
            Console.WriteLine("---------------------------------");
            Employee Employee2 = new Employee("prajwal","giri");
            Console.WriteLine("----------------------------------");
            Employee Employee3 = new Employee(25,"prajwal giri","birtamode",14);
            Console.WriteLine("-----------------------------------");
            Employee Employee4 = new Employee(20,"suraj");

        }
    }
}*/