using ConsoleApp1.Models;

Console.WriteLine("welcome to the library system");
Console.WriteLine("Are you librarain or regular user (L/R)");

Library library = new Library();

char UserType = Console.ReadLine().ToUpper()[0];

if (UserType == 'L')
{
    Console.WriteLine("Enter the librarian name");
    string LibrarianName = Console.ReadLine();
    Librarian librarian = new Librarian(LibrarianName);

    Console.WriteLine($"Welcome {librarian.Name}");

    

    while (true)
    {
        Console.WriteLine("Please choose to Add book (A) OR Remove Book (R) OR Display books (D)");
        char choice = Console.ReadLine().ToUpper()[0];
        switch (choice)
        {
            case 'A':
                Console.WriteLine("Enter Book Details");
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Author: ");
                string author = Console.ReadLine();
                Console.Write("Year: ");
                int year = int.Parse(Console.ReadLine());
                Book Book = new Book(title, author, year);
                librarian.Add(Book, library);
                break;


            case 'R':
                Console.WriteLine("Enter Book Details");
                Console.Write("Title: ");
                title = Console.ReadLine();
                librarian.Remove(title, library);

                break;


            case 'D':
                Console.WriteLine("The book list");
                librarian.DisplyBook(library);
                break;
            default:
                 Environment.Exit(0);
                break;
        }
        
    }
}
else if (UserType == 'R')
{
    Console.WriteLine("Enter the User name");
    string UserName = Console.ReadLine();
    LibraryUser user = new LibraryUser(UserName);
    Console.WriteLine($"Welcome {user.Name}");
    while (true)
    {
        Console.WriteLine("Please choose to Borrow Books (B) OR Display books (D)");
        char choice = Console.ReadLine().ToUpper()[0];
        switch (choice)
        {
            case 'A':
                Console.WriteLine("Enter Book Details to borrow");
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Author: ");
                string author = Console.ReadLine();
                Console.Write("Year: ");
                int year = int.Parse(Console.ReadLine());
                Book Book = new Book(title, author, year);
                user.BorrowBook(Book, library);
                break;

            case 'D':
                Console.WriteLine("The book list");
                user.DisplyBook(library);
                break;
            default:
                Environment.Exit(0);
                break;
        }
    }
}
else
{
    Console.WriteLine("Invalid input");
}
