/*namespace C_Sharp_Notes_101;

// STRING AND CHARACTER DATATYPE

// string stores multiple characters in a single variable.
// double quotes will be used with string data type.


// char stores single character at a time in a variable.
// single quotes is used with character data type.

// Escape sequence 

// Verbatim Literal

// *  Verbatim literal  is a string with an @ symbol.
// * Verbatim literal makes escape sequences translate as normal.

public class String_Character_EscapeSequence
{
    static void Main(string[] args)
    {
        string name = "Prajwal";   // string 
        char a = '3';              // char
        char b = 'Z';             // char
        string mix = "12abc";     // string
        
        // Escape sequence

        string address = "Birtamode\tJhapa";              // using tab
        string z = "1\n2\n3\n4";                          // using new line
        Console.WriteLine(address);
        Console.WriteLine(z);


        string url = "E:\\.NET projects learning\\MyMovie";  // using escape sequences.
        
        string urls = @"E:\.NET projects learning\MyMovie"; // using verbatim literal.

        Console.WriteLine(url);
        Console.WriteLine(urls);

    }
}*/