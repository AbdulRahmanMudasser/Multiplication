using System;

class Multiplication
{
    static void Main(string[] args)
    {
        // declaring variables
        int x, y, z;

        // prompting and taking input for x
        Console.Write("Enter Value Of x:  ");
        x = Convert.ToInt32(Console.ReadLine());

        // prompting and taking input for y
        Console.Write("Enter Value Of y:  ");
        y = Convert.ToInt32(Console.ReadLine());

        // prompting and taking input for z
        Console.Write("Enter Value Of z:  ");
        z = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();    // just for spacing 

        // multiplying x, y and z
        Console.WriteLine("Product Of x, y and z:  " + (x * y * z));
    }
}
