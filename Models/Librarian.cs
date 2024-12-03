using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Librarian : User
    {
        public int EmpolyeeNumber { get; set; }


        public Librarian(string name)
        {
            Name = name;
        }

        public void Add (Book book , Library library)
        {
            library.Add (book);
        }

        public void Remove(string nameofbook , Library library)
        {
            library.Remove(nameofbook);
        }
    }
}
