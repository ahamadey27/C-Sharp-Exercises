using System;
using Arrays;

public class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book(); //Boob object, instance of the book class
        book1.title = "Harry Potter";
        book1.author = "JK Rawling";
        book1.pages = 400;

        Book book2 = new Book(); //Boob object, instance of the book class
        book2.title = "Lord of the Rings";
        book2.author = "JK Lord";
        book2.pages = 700;

        System.Console.WriteLine(book2.title);
    }
}