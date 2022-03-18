/*namespace C_Sharp_Notes_101;

public class Creating_Array_with_User_Input
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter the number of rows");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of columns");
        int column = int.Parse(Console.ReadLine());
        int[,] my_array = new int[rows, column];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Console.WriteLine($"enter the number for index {i} {j}");
                my_array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        foreach (int item in my_array)
        {
            Console.WriteLine(item);
        }
















        /*Console.WriteLine("How many names you want to enter:");
        int numberof = int.Parse(Console.ReadLine());
        string[] names = new string[numberof];

        for (int i = 0; i < numberof; i++)
        {
            Console.WriteLine($"Enter index no {i} name");
            names[i] = Console.ReadLine();
        }

        foreach (string name in names)
        {
            Console.Write($"{name},");
        }#1#

        /*Console.WriteLine("How many numbers of number you want to enter.");
        int number = int.Parse(Console.ReadLine());
        int[] my_array = new int[number];
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"Enter value to put in {i} index");
            my_array[i] = int.Parse(Console.ReadLine()); 

        }
 
        foreach (int item in my_array)
        {
            Console.Write($"{item} ");
        }#1#

    }
}*/