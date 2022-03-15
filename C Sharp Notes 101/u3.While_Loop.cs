/*namespace C_Sharp_Notes_101;
// While loop is used to execute a block of code repetitively as long the condition of the loop remains true.

// The While loop consists of the while statement, which begins with the while keyword followed by a boolean 
// condition

// If the condition evalutes to true, the block of statements after the while statement is executed.

// After each iteration, the control is transferred back to the while statement and the condition is checked 
// again for another round of execution.

// When the condition is evaluated to false, the block of statements following the while statements is 
// ignored and the statement appearing after the block is executed.


public class While_Loop
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter any number for table");
        int number = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine($"{number} * {i} = {i * number}");
            i++;
        } 
    }
}*/