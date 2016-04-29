using System;

internal class Tester
{
    static void Main()
    {
        // Using constants to set the size of each dimension.
        const int rows = 14;
        const int cols = 8;

        // Declare a 14x8 integer array.
        int [,] rArray = new int[rows, cols];

        // Populate the array, i = row, j = column
        for (int i=0; i<rows; i++)
        {
            for (int j=0; j<cols; j++)
            {
                rArray[i,j] = i+j;
            }
        }

        // Write the column headers out.
        Console.WriteLine("        C1    C2    C3    C4    C5    C6    C7    C8 ");
        Console.WriteLine("       ----  ----  ----  ----  ----  ----  ----  ----");
        Console.WriteLine();

        // Display the contents of the array.
        for (int i=0; i<rows; i++)
        {
            // Write the row header out.
            Console.Write ("R-{0}:  ", (i+1).ToString ("00"));

            for (int j=0; j<cols; j++)
            {
                // Write the row data out.
                Console.Write ("{0}   ", rArray[i,j].ToString(" 00"));
            }

            // Go to the next line for output.
            Console.WriteLine();
        }

        Console.Write ("\n\nPress <ENTER> to end: ");
        Console.ReadLine();
    }
}
