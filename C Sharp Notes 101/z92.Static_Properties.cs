/*namespace C_Sharp_Notes_101;


// STATIC PROPERTY

// The static Property is used to access and manipulate static fileds of a class in a safe manner.

// The static property declared by using the static keyword.

// The static property accessed using the class name and thus, belongs to the class rather than just an instance of the class.

// The static property called by a programmer without creating an instance of a class.

// We cannot initialize instance fields within static property.


class University
{
   private static string _UniversityName;
   private static string _DepartmentName;

   public static string UniversityName
   {
      set
      {
         if (string.IsNullOrEmpty(value))
         {
            Console.WriteLine("You cannot enter null or empty value");
         }
         else
         {
            _UniversityName = value;
         }

      }
      get { return _UniversityName; }
   }

   public static string DepartmentName
   {
      set
      {
         if (string.IsNullOrEmpty(value))
         {
            Console.WriteLine("Department name cannot be null or empty");
         }
         else
         {
            DepartmentName = value;
         }
      }
      get { return _DepartmentName; }

   }



   public class Static_Properties
   {

      static void Main(string[] args)
      {
         University.UniversityName = "Tribhuwan University";
         Console.WriteLine($"Your university name is {University.UniversityName}");
         University._DepartmentName = "Software Engineering";
         Console.WriteLine($"University Department Name is {University._DepartmentName}");

      }
   }
}*/