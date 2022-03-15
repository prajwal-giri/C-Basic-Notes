/*using System.Diagnostics;
using System.Security.Principal;

namespace C_Sharp_Notes_101;

public class restarting_C__program_With_user_input
{
    static void Main(string[] args)
    {


        while (true)
        {

            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine($"The sum of {first} and {second} is {first + second}");

            Console.WriteLine("Do you want to repeat the addition?");
            string confirm = Console.ReadLine().ToLower();

            if (confirm == "yes")
                {
                continue;
            }
            else { break; }
        }
        Console.WriteLine("Outside of loop");


        *//*string confirm;
        do { 

        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());

        Console.WriteLine($"The sum of {first} and {second} is {first + second}");
        
        Console.WriteLine("Do you want to repeat the addition?");
        confirm = Console.ReadLine().ToLower();
        

        } while(confirm == "yes");   *//*
    }
} */