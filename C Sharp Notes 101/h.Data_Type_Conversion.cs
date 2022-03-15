/*namespace C_Sharp_Notes_101;
// DATA TYPE CONVERSION

// IMPLICIT AND EXPLICIT CONVERSION

// Implicit conversion is  done by Complier when there is no loss of information while converting.
// and if there is no possibility of throwing exeption during the conversion.

// Example: Converting from schar to int to float to double to decimal 
public class Data_Type_Conversion
{
    static void Main(string[] args)
    {
        /*
        int a = 20;
        float b = a;  // implicit data conversion.
        
        float x = 30.2f;
        int y = (int)x;  // explicit data conversion and some data will get lost during conversion.

        string firstnum = "85";
        string secondnum = "85.8";
        float thirdnum = 101.35f;

        int first_num = Convert.ToInt32(firstnum);
        double second_num = Convert.ToDouble(secondnum);
        int third_num = Convert.ToInt32(thirdnum);
        
        Console.WriteLine(first_num);
        Console.WriteLine(second_num);
        Console.WriteLine(third_num);
        #1#
        
        
        // parse only takes string.

        /*int q = 3;
        float r = float.Parse(q);#1#  // error as parse only takes integer.


        Console.WriteLine("Enter first number");
        float num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number");
        float num2 = float.Parse(Console.ReadLine());

        float sum = num1 + num2;
        Console.WriteLine($"The sum of {num1} and {num2} is {sum}");

        /*string test = "50a"; 
        int test1 = Convert.ToInt32(test);  // error.
        int test2 = int.Parse(test);#1#    // error
    }
}*/