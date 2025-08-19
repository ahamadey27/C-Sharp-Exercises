using System;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            System.Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine(num1 / num2);
        }
        catch (DivideByZeroException e)
        {
            System.Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            System.Console.WriteLine(e.Message);
        }
        finally //any code is always going to get executed no matter what
        {
            System.Console.WriteLine("End of program");

        }
    }
}