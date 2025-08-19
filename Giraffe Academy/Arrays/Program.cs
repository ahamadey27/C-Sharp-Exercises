using System;
using Arrays;

public class Program
{
    static void Main(string[] args)
    {
        //This is a slow way to build objects
        // Book book1 = new Book("Bill"); //Book object, instance of the book class
        // book1.title = "Harry Potter";
        // book1.author = "JK Rawling";
        // book1.pages = 400;

        // Book book2 = new Book("John");
        // book2.title = "Lord of the Rings";
        // book2.author = "JK Lord";
        // book2.pages = 700;

        Book book1 = new Book("Lord of the Rings", "JK Rawlings", 400);
        Book book2 = new Book("The Hobbit", "Billy", 800);
        book1.author = "Tolkin"; 

        System.Console.WriteLine(book1.author);




    }
}