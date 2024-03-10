public class Book : LibraryItem
{
    public string Author { get; set; }

    public Book(int id, string title, int yearPublished, string author)
        : base(id, title, yearPublished)
    {
        Author = author;
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"Author: {Author}");
    }
}