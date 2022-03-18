/*namespace C_Sharp_Notes_101;

// Value Type and Reference Type.

// STACK AND HEAP MEMORY CONCEPT.


// EXAMPLES WITH STRUCT AND CLASS.
// BOTH ARE SAME ALMOST UPTO 80 PERCENT.

// MAIN DIFFERENCE IS:
// STRUCT ---  VALUE TYPE ---- STACK 
// CLASS ----- REFERENCE TYPE ---HEAP


// VALUE TYPE

// A data type is a value type if it holds a data value within its own memory space. It Means variables of these data types directly contain their values.

// Examples: enum,struct,bool,byte,char,decimal,double,float,int,long,sbyte,short 
// In Value type the object is created in Stack memory. 

// Heap has more space memory than stack.  

// Value type like structs are stored in Stack Memory.

// Changes in the value of In one object or one memory, doesn't affect another , as it sits on different block of memory on stack.

// And if there is more memory location on the stack, due to value type, then there comes the exeptions of stack overflow.

// Cannot contain null values.

// Memory is allocated at compile time.



// REFERENCE TYPE


// Unlike value types, a reference type doesn't store its value directly. Instead , it stores the address where the value is being stored. In other words, a reference 
// Type contains a pointer to another memory location that holds the data.

// Examples: String,Arrays,Class, Objects, Delegates, Interface.

// In Reference type, the object is created in Heap Memory.  

// // Employee e means declaring reference variables and is always made in Stack Memory/and new Employee(); this creates
// object in Heap Memory.

// It only saves memory location (Location details of object in Heap Memory) in Stack 
// Meaning Object is created in Heap and the address of heap memory is saved on Stack for reference.

// Can contain null values.

// Memory is allocated at run-time.

// Example of stack memory using struct.(value type)

// struct Student
// {
//     public int Id;
//     public int Standard;
//     public string FullName;
//     public int Age;
//     public int RollNo;
//     public int Address;
// }



// Example of heap memory using class. (reference type)


class Employee
{
    public int Id;
    public string FullName;
    public string Address;
    public int Age;
    public string PhoneNo;
    public int Salary;

}

public class Value_and_Reference_Type_Stack_Heap
{
    static void Main(string[] args)
    {
        // Example of heap memory using class. (reference type)


        Employee e = new Employee();    // Employee e means declaring reference variables and is always made in Stack Memory/and new Employee(); this creates
        // object in Heap Memory.
        e.Salary = 4000;
        e.Age = 30;

        Employee e1 = e;   // e1 new block is added in stack, sharing the same memory address as object e, thus, object e1 details will have same datas, 
        // also any change in any object will change all the objects, as they share same memory address pointing to the same object in heap. 
        Employee e2 = e;
        e.Age = 25; 
        Console.WriteLine(e1.Age);
        Console.WriteLine(e2.Age);




        // Example of stack memory using struct.(value type)


        // Student obj = new Student();   // Here Student obj means we are creating an object of struct student  and assigning the name of obj to it.
        // obj.Id = 5;
        // obj.Standard = 10;
        // obj.FullName = "Prajwal Giri";
        // obj.Age = 30;
        //
        // Student obj1 = obj;
        // Student obj2 = obj;
        //
        //
        // obj.Age = 28;
        // Console.WriteLine(obj.Age);
        // Console.WriteLine(obj1.Age);
        // Console.WriteLine(obj2.Age);





    }
}*/