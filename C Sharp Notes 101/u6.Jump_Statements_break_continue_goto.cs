namespace C_Sharp_Notes_101;
// Jump Statements are used to transfer control from one point in a program to another.

// There will be situations where you need to exit out of a loop prematurely and continue with the program.

// In such cases, jump statements are used. Jump Statements unconditionally transfer control of a program to a different 
// location.

// The location to which jump statement transfers control is called the target of the jump statements. 

// C# supports four types of jump statements.

// * break
// * continue
// * goto
// * return

public class Jump_Statements
{
   static void Main(string[] args)
   {
      for (int i = 1; i <= 10; i++)
      {
         Console.WriteLine(i);

         if (i == 5)
         {
          
            continue;
         }

         
      }
      Console.WriteLine("Loop Termintes.");
   }
}