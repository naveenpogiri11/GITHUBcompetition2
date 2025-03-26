// Library.cs
using System;
using System.Collections.Generic;

public class Library
{
    public List<Book> Books { get; set; } = new List<Book>();
    public List<Person> Patrons { get; set; } = new List<Person>();

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void AddPatron(Person patron)
    {
        Patrons.Add(patron);
    }

    public void DisplayBooks()
    {
        Console.WriteLine("\nBooks in Library:");
        foreach (var book in Books)
        {
            Console.WriteLine(book);
        }
    }

    public void DisplayPatrons()
    {
        Console.WriteLine("\nPatrons in Library:");
        foreach (var patron in Patrons)
        {
            Console.WriteLine(patron);
        }
    }

    public void BorrowBook(string patronName, string bookTitle)
    {
        Book book = Books.Find(b => b.Title == bookTitle);
        if (book != null && book.BorrowBook())
        {
            Console.WriteLine($"{patronName} borrowed '{bookTitle}'");
        }
        else
        {
            Console.WriteLine($"Sorry, '{bookTitle}' is not available for borrowing.");
        }
    }
}