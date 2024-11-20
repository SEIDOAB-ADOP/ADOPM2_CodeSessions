namespace _15_shallow_vs_deep_copy;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book() { }
    public Book(Book org)
    {
        Title = org.Title;
        Author = org.Author;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("15_shallow_vs_deep_copy");
        Book[] books = new Book[]
            { new Book { Title = "The Adventures of Tom Sawyer", Author = "Mark Twain" },
              new Book { Title = "The Alchemist", Author = "Paulo Coelho" }};
        Book[] booksCopy = new Book[2];

        //Copy 1 - booksCopy is a simple reference copy of books
        booksCopy = books;
        booksCopy[0].Title = "Frankenstein";
        Console.WriteLine(books[0].Title);

        booksCopy[0] = null;
        //Console.WriteLine(books[0].Title);    //this will crash
        Console.WriteLine(books[0]?.Title);   //this will be null


        books = new Book[]
            { new Book { Title = "The Adventures of Tom Sawyer", Author = "Mark Twain" },
              new Book { Title = "The Alchemist", Author = "Paulo Coelho" }};
        booksCopy = new Book[2];

        //Copy 2 - booksCopy is a shallow copy of books, i.e. booksCopy has it's
        //         own array but elements are referring to same csBook instances
        //         as books array elements does
        Array.Copy(books, booksCopy, books.Length);
        booksCopy[0].Title = "Frankenstein";
        Console.WriteLine(books[0].Title);

        booksCopy[0] = null;
        Console.WriteLine(books[0].Title);


        books = new Book[]
            { new Book { Title = "The Adventures of Tom Sawyer", Author = "Mark Twain" },
              new Book { Title = "The Alchemist", Author = "Paulo Coelho" }};
        booksCopy = new Book[2];

        //Copy 3 - booksCopy is a deep copy of books, i.e. booksCopy has it's
        //         own array BUT elements in booksCopy are now referring to new csBook instances,
        //         created by the copy contructor
        for (int i = 0; i < books.Length; i++)
        {
            booksCopy[i] = new Book(books[i]);
        }
        booksCopy[0].Title = "Frankenstein";
        Console.WriteLine(books[0].Title);

        booksCopy[0] = null;
        Console.WriteLine(books[0].Title);
    }
}

