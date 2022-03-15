/*namespace C_Sharp_Notes_101;

// SWITCH_CASE and BREAK also use default.

// A program is difficult to comprehend when there are too many if statements representing multiple selection constructs.
// Switch case is used if there is multiple if conditions.
public class Switch_Case
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();

        switch (name)
        {
            case "prajwal":
                Console.WriteLine("You are part of the family");
                break;
            
            case "shrishant":
                Console.WriteLine("Your are the main part of family");
                break;
            
            case "kamala":
                Console.WriteLine("you are the mother of family");
                break;
            
            case "sujata":
                Console.WriteLine("you are the important part of the family");
                break;
            
            default:
                Console.WriteLine("you are not part of the family");
                break;
        }



        // another example

        /*Console.WriteLine("Enter 01 to 07 to find day of the week: ");
        int week_number = int.Parse(Console.ReadLine());

        switch (week_number)
        {
            case 1:
                Console.WriteLine("The day is monday");
                break;
            
            case 2:
                Console.WriteLine("the day is tuesday");
                break;
            
            case 3:
                Console.WriteLine("the day is wednesday");
                break;
            
            case 4:
                Console.WriteLine("the day is thursday");
                break;
            
            case 5:
                Console.WriteLine("the day is friday");
                break;
            
            case 6:
                Console.WriteLine("the day is saturday");
                break;
            
            case 7:
                Console.WriteLine("the day is sunday");
                break;
            
            default:
                Console.WriteLine("Invalid Number entered");
                break;
        }

        Console.WriteLine("End of the program");#1#
    }
}*/