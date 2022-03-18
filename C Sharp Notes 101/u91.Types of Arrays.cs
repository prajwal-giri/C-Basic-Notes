/*
namespace C_Sharp_Notes_101;

// Based on how array store elements, arrays can be cateogorized into following two types.

// Single Dimension Array
// Multi-Dimension Array
// Multi-Dimension Array is also called array of arrays.
// A Multi-Dimension Array allows you to store combination of values of a single type in two or more dimensions.
// The dimension of the array are represented as rows and columns.

// Multi-Dimension Array are of two types:
// Regtangular array
// Jagged array





public class Types_of_Arrays
{
  static void Main(string[] args)
  {
      // Examples of Jagged Array using foreach.
      
      int[][] my_array = new int[3][];

      my_array[0] = new[] {1, 3, 5, 2, 6};
      my_array[1] = new[] {7, 9, 11, 111, 121, 152, 171};
      my_array[2] = new[] {13, 15, 17};
      
      
      foreach (int[] item in my_array)
      {
          foreach (int i in item)
          {
              Console.Write($"{i} ");
          }

          Console.WriteLine();
      }
      
     //  Examples of Jagged Array using nested for
     
     
      /*
      int[][] my_array = new int[3][];

      my_array[0] = new[] {1, 3, 5, 2, 6};
      my_array[1] = new[] {7, 9, 11, 111, 121, 152, 171};
      my_array[2] = new[] {13, 15, 17};

      for (int i = 0; i < my_array.GetLength(0); i++)
      {
          for (int j = 0; j < my_array[i].Length; j++)
          {
              Console.Write($"{my_array[i][j]} ");
          }

          Console.WriteLine();#1#
 














      // rectungular multi dimension using for each
      //
      // int[,] my_array = new int[3, 4]
      // {
      //     {12, 14, 18, 20},
      //     {22, 24, 26, 28},
      //     {30, 32, 34, 36}
      // };
      //
      // foreach (int item in my_array)
      // {
      //     Console.WriteLine(item);
      // }



      // rectungular multi dimension using nested for
      /*
      int[,] my_array = new int[3, 4]
      {
          {12, 14, 18, 20},
          {22, 24, 26, 28},
          {30, 32, 34, 36}
      };

      for (int i = 0; i < my_array.GetLength(0); i++)
      {
          for (int j = 0; j < my_array.GetLength(1); j++)
          {
              Console.Write($"{my_array[i,j]} ");
          }

          Console.WriteLine();#1#
  }




      // Examples of Single Dimension Array

      /*
      int[] my_array = new int[5];
      my_array[0] = 25;
      my_array[1] = 28;
      my_array[2] = 35;
      my_array[3] = 8;
      my_array[4] = 14;#1#

      }
      */
