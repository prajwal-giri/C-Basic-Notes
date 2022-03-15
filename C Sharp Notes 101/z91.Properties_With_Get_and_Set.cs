/*namespace C_Sharp_Notes_101;

// Properties allow you to control the accessibility of a class variables, and are the recommended
// way to access variables from the outside in C#.

// A property is much like a combination of a variable and a method.
// It can't take any parameters, but you are able to process the value before it's assigned to our returned.

// Properties are like data fields(variables) but have logic behind them.

// From the outside, they look like any other member variable , but they act like a member function.

// defined like a filed, with "get" and "set" accessors code added.

// Properties are also used in Encapsulation.

// Types of Properties 

// Read/Write Properties
// Read only Properties
// Write Only Properties
// Auto Implemented Properties



class Student
{
    private int _StdId;
    private string _Name;
    private int _TotalMarks = 100;
    private string _Fname;
    
    // auto implemented properties

    /*
    public string UserName { get; set; }
    public string Password { get; set; }
    #1#
    
    
   public string UserName { get; private set; }             // this is properties //
   public string Password { get;  private set; }

   public Student(string uName, string Pass)
   {
       UserName = uName;
       Password = Pass;
   }


    
    //creating write only properties with set.

    public string Fname
    {
        set
        {
            this._Fname = value;
        }
    }

    // creating readonly properties with get.
    public int TotalMarks
    {
        get
        {
            return this._TotalMarks;
        }
    }
    
    // properties for _stdID   (read/write) with set/get
    public int Std
    {
        set
        {
            if (value <=0)
            {
                Console.WriteLine("Id cannot be zero or negative"); 
                    
            }
            else
            {
                this._StdId = value;   
            }
            
        }
        get
        {
            return this._StdId;
        }
    }
    // properties for _Name  (read/write) with set/get  

    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Please enter your name");
            }
            else
            {
                this._Name = value;
            }
            
        }
        get
        {
            return this._Name;
        }
    }
    
}

public class Properties_With_Get_and_Set
{
    static void Main(string[] args)
    {

        Student s1 = new Student("prajwal","prajwal123");
        /*s1.UserName = "Raju";
        s1.Password = "Raju123";#1#  
        Console.WriteLine(s1.UserName);
        Console.WriteLine(s1.Password);


        /*Student s = new Student();
        s.Std = 2;
        s.Name = "";
        Console.WriteLine(s.TotalMarks);
        Console.WriteLine(s.Std);
        s.Fname = "Nagendra Kamal Giri";
        s.UserName = "Prajwal";
        s.Password = "Prajwal123";
        Console.WriteLine(s.UserName);
        Console.WriteLine(s.Password);
        #1#


    }
}*/