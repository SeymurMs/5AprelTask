using System;
using System.Collections.Generic;
using System.Text;

namespace _5AprelTask
{
    internal class Library
    {
        public List<Book> books = new List<Book>();

        public List<Book> FilterByPrice(int min , int max)
        {
            return books.FindAll(book => book.Price < min && book.Price > max);
        }
        public List<Book> FilterByGenre(Genre genre)
        {
            return books.FindAll(book=> book.Genre == genre);

        }
        public Book FİndBookByNo(int? no)
        {
            return books.Find(book=> book.No == no);
        }
    }
}
