public abstract class LibraryItem
{
    public int ID { get; set; }
    public string Title { get; set; }
    public int YearPublished { get; set; }

    protected LibraryItem(int id, string title, int yearPublished)
    {
        ID = id;
        Title = title;
        YearPublished = yearPublished;
    }

    public virtual void PrintDetails()
    {
        Console.WriteLine($"ID: {ID}, Title: {Title}, Year Published: {YearPublished}");
    }
}