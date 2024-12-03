using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Library
    {
        private Book[] _books = new Book[100];
        private int _currentBookCount = 0;
        private Book[] _borrowBooks = new Book[50];
        private int _currentBorrowedBoookCount = 0;   

        public void Display()
        {
            foreach(var book in _books)
            {
                if (book != null)
                {
                    Console.WriteLine(book.Title);
                }
            }
        }

        public void Add(Book book)
        {
            if (_currentBookCount < _books.Length)
            {
                _books[_currentBookCount] = book;
                _currentBookCount++;
                Console.WriteLine("Book adding succesfuly");
            }
            else
            {
                Console.WriteLine("Library is full, can not add new book!");
            }
        }

        public void Remove(string bookname)
        {
            for (int i = 0; i < _currentBookCount; i++) {
                if (_books[i].Title == bookname)
                { _books[i] = null;
                _currentBookCount--;
                    Console.WriteLine("Book removing succesfuly");
                    return;
                }else
                {
                    Console.WriteLine("book name is not exist");
                }
            }
          
        }

        public void BorrowBook(Book book) 
        {
            if (_currentBorrowedBoookCount < _borrowBooks.Length)
            {
                _books[_currentBorrowedBoookCount] = book;
                _currentBorrowedBoookCount++;
                Console.WriteLine("Book Borrowed succesfuly");
            }
            else
            {
                Console.WriteLine("sorry can not borrow more books");
            }
        }
    }
}
