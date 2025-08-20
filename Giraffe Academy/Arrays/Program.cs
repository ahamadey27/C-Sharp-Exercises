using System;
using Arrays;

public class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Enter five numbers");
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            System.Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            
        }
 
        Array.Reverse(numbers);
 
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }
       




    }
}