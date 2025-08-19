using System;
using Arrays;

public class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Jim", "History", 2.8);
        Student student2 = new Student("Pam", "PolySci", 4.0);

        System.Console.WriteLine(student1.HasHonors());
        System.Console.WriteLine(student2.HasHonors());
       




    }
}