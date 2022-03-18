/*
namespace C_Sharp_Notes_101;

public class Creating_Calculator
{

    public static double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    public static double Sub(double num1, double num2)
    {
        return (num1 - num2);
    }


    public static double Mul(double num1, double num2)
    {
        return num1 * num2;
    }

    public static double Div(double num1, double num2)
    {
        return num1 / num2;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Calculator Program");
        Console.WriteLine("------------------------------------");
        string answer;
        do
        {
            Console.WriteLine("Enter first number");
            double first = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            double second = double.Parse(Console.ReadLine());

            Console.WriteLine("Which Function you want to run?");
            Console.WriteLine("Enter '+' for Addition.");
            Console.WriteLine("Enter '-' for Subtraction.");
            Console.WriteLine("Enter '*' for Multiplication.");
            Console.WriteLine("Enter '/' for Division.");
            string calculation = Console.ReadLine();


            if (calculation.Equals("+"))
            {
                Console.WriteLine(Add(first, second));

            }
            else if (calculation == "-")
            {
                Console.WriteLine(Sub(first, second));
            }
            else if (calculation == "*")
            {
                Console.WriteLine(Mul(first, second));
            }
            else if (calculation == "/")
            {
                Console.WriteLine(Div(first, second));
            }
            else
            {
                Console.WriteLine("Invalid Function");
            }

            Console.WriteLine("do you want to continue? ");
            answer = Console.ReadLine().ToUpper();


        } while (answer == "YES");



    }
}
*/


    
    