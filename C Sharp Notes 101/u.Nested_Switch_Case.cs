/*using System.Threading.Channels;

namespace C_Sharp_Notes_101;

// NESTED SWITCH CASE.
public class Nested_Switch_Case
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the laptop brand you want to buy: ");
        string brand = Console.ReadLine();
        
        switch(brand)
        {
           case "dell":
               Console.WriteLine("Welcome to Dell Company Laptop.");
               break;
           
           case "lenevo":
               Console.WriteLine("Welcome to Lenevo Company Laptop");
               break;
           
           case "apple":
               Console.WriteLine("Welcome to the Apple Mac Book");
               Console.WriteLine("Enter which model do you want to purchase");
               string model = Console.ReadLine();
               switch (model)
               {
                   case "macbookair":
                       Console.WriteLine("you have chosen macbook air .");
                       break;
                   
                   case "macbookpro":
                       Console.WriteLine("you have chosen macbook pro. ");
                       break;
                   
                   default:
                       Console.WriteLine("invalid model.");
                       break;
               }

               break;
           
           
               default:
                   Console.WriteLine("Invalid Brand");
                   break;
        }
    }
}*/