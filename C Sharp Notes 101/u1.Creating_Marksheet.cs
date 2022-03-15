/*
using System;

namespace C_Sharp_Notes_101;


public class Creating_Marksheet
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your standard: ");
        int standard = int.Parse(Console.ReadLine());
        
        Console.Write("Enter your roll no: ");
        int roll = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the marks of Science");
        int science = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the marks of computer");
        int computer = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the marks of english");
        int english = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the marks of nepali");
        int nepali = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the marks of account");
        int account = int.Parse(Console.ReadLine());

        int total_marks = account + computer + english + nepali + science;
        double percentage = total_marks * 100 / 500;

        Console.WriteLine($"Your name is {name}");
        Console.WriteLine($"Your class is {standard}");
        Console.WriteLine($"Your roll no is {roll}");
        Console.WriteLine($"Your total marks is {total_marks}");
        Console.WriteLine($"Your percentage is {percentage}");

        if (percentage >= 80)
        {
            Console.WriteLine("Distinction"); 
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("First Division");
        }
        else if (percentage >= 50)
        {
            Console.WriteLine("Second Division");  
        }
        else if (percentage >= 40)
        {
            Console.WriteLine("third Division");
        }
        else
        {
            Console.WriteLine("Failed");
        }
    }


    }
    */
   
