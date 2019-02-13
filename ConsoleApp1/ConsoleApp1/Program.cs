using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class Book {
            private string title;
            private string author;
            private int pages;
            private string owner;
            private int read;

            Book(title, author, pages, owner)
            {
                read = 0;
            }
        }
    }
}
