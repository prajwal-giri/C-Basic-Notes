/*
namespace C_Sharp_Notes_101;
// STANDARD DATE AND TIME FORMAT SPECIFIERS//

// DATE AND TIME FORMAT SPECIFIERS//

// A date and time format specifier is a special character that enables you to display the date and time values in different formats.

// * Format Specifier                          // * Name
// d -----------                                short date
// D -----------                                long date
// f -----------                                Full Date/time(short time)
// F -----------                                Full Date/time(long time)
// g -----------                                General date/time(short time)
// G -----------                                General date/time (long time)
// m or M ------                                Month day
// t ----------                                 Short time
// T ----------                                 Long time
// y or Y-----                                  Year month pattern
// ddd -------                                  Represents the abbreviated name of the day of the week.
// dddd -------                                 Represents the full name of the day of the week.
// FF --------                                  Represents the two digits of the seconds fraction
// HH --------                                  Represents the month as a number from 01 to 12
// MMM--------                                  Represents the abbreviated name of the month
// ss---------                                  Represents the seconds as a number from 0 to 59


public class Date_Time_Format_Specifiers
{
    static void Main(string[] args)
    {
        DateTime dt = DateTime.Now;         // Creating object dt from system class DateTime)
        Console.WriteLine(dt);

        Console.WriteLine("{0:d}",dt);
    }
}
*/


