/*namespace C_Sharp_Notes_101;

// IF ELSE
// SELECTION STATEMENTS IS USED IN DECISION MAKING.

// is a programming construct that controls the flow of the program.
// Executes a particular block of statements based on boolean condition which is an expression returning true or false.
// Is referred to as a decision-making  construct.
// Allow you to take logical decisions about executing different blocks of a program to achieve the required logical output.

public class Decision_Making_Statements
{
   static void Main(string[] args)
   {
      Console.Write("Enter your username: ");
      string username = Console.ReadLine();

      Console.Write("Enter your password: ");
      string password = Console.ReadLine();
      
      if ((username == "prajwal123") && (password == "prajwal@123"))
      {
         Console.WriteLine("Login Successful");
      }
      else
      {
         Console.WriteLine("Incorrect username or password");
      }





      /*Console.Write("Enter the value of x:");
      int x = int.Parse(Console.ReadLine());
      if (x > 10)
      {
         Console.WriteLine("X is greater than 10");
      }
      else
      {
         Console.WriteLine("X is not greater than 10.");
      }#1#
   }
   
}*/