using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class Book
    {
        //All class attributes 
        public string? title;
        public string? author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages) //How to make a constructor 
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}