using System;

public class Program
{
    static void Main(string[] args)
    {
        int[,] numberGrid = { //2D array...each comma is a new dimension 
            {1, 2},
            {3, 4},
            {5, 6}
        };

        System.Console.WriteLine(numberGrid[1, 1]);
    }
}