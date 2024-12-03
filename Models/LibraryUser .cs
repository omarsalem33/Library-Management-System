using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class LibraryUser : User
    {
        public LibraryCard Card { get; set; } // Aggregation Relationship
        public LibraryUser(string name)
        {
            Name = name;
        }

        public void BorrowBook(Book book , Library library)
        {
            library.BorrowBook(book);
        }
    }
}
