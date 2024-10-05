namespace CreationalDesignPatterns.Prototype.Library;

public class Library
{
    public string? Title { get; set; }
    public IEnumerable<string>? BooksList { get; set; }

    public Library()
    {
    }
    public Library(string title)
    {
        this.Title = title;
        this.BooksList = GetBooksList();
    }

    public Library Clone(string title)
    {   
        Library lib = new Library();
        lib.Title = title;
        // occurs shallow copy
        lib.BooksList = this.BooksList;
        return lib;
    }

    private IEnumerable<string> GetBooksList()
    {
        //it's an expensive process
        var books = new string[10];
        for (int i = 0; i < 10; i++)
        {
            books[i] = $"Book{i + 1}";
        }
        Thread.Sleep(3000);
        Console.WriteLine("<><><><><><>Expensive Process<><><><><><");
        return books;
    }
}
