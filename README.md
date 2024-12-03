# Library Management System

## Overview

This project is a simple console-based Library Management System. It allows users to interact with the library as either a librarian or a regular user. The system supports adding, removing, and displaying books for librarians, and borrowing and displaying books for regular users.

## Features

### For Librarians
- **Add Book**: Librarians can add new books to the library by providing the title, author, and year of publication.
- **Remove Book**: Librarians can remove books from the library by providing the title of the book.
- **Display Books**: Librarians can display the list of all books available in the library.

### For Regular Users
- **Borrow Book**: Users can borrow books from the library by providing the title, author, and year of publication.
- **Display Books**: Users can display the list of all books available in the library.

## Usage

1. **Run the Program**: Execute the `Program.cs` file to start the application.
2. **Choose User Type**: The system will prompt you to choose whether you are a librarian or a regular user by entering 'L' or 'R'.
3. **Librarian Actions**:
   - Enter your name.
   - Choose to add, remove, or display books by entering 'A', 'R', or 'D'.
   - Follow the prompts to complete the chosen action.
4. **Regular User Actions**:
   - Enter your name.
   - Choose to borrow or display books by entering 'B' or 'D'.
   - Follow the prompts to complete the chosen action.

## Code Structure

- **Program.cs**: The main entry point of the application. It handles user input and directs the flow based on user type and actions.
- **Models**: Contains the classes `Library`, `Librarian`, `LibraryUser`, and `Book` which define the core functionality and data structures of the system.

## User Stories 
1. As a user I want to have a library card so that I can borrow books from the  library.
2. As a librarian I want to add a new book to the library's collection so that they can be available for borrowing.
3. As a librarian I want to remove books form the library's collection so that they can keep the collection up to date.
4. As a librarian I want to display a list of all books in the library collection so that users can easily find a book they are interested in.
