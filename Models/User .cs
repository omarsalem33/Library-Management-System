using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public abstract class User
    {
        public string Name { get; set; }

        public void DisplyBook(Library library)
        {
            library.Display();
        }
    }
}
