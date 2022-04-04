    using System;
using System.Collections.Generic;
using System.Text;

namespace _5AprelTask
{
    internal class Book
    {
        public Book()
        {
            _no++;
            No = _no;
        }
        int _no;
        public int No { get; }
        public Genre Genre;
        public double Price { get; set; }

        public string  AuthorName { get; set; }
    }
}
