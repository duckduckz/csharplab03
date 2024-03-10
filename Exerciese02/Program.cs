
class Program02
{
    static void Main(string[] args)
    {
        var items = new List<LibraryItem>
        {
            new Book(1, "The Great Gatsby", 1925, "F. Scott Fitzgerald"),
            new Magazine(2, "National Geographic", 2023, 1),
            new DVD(3, "Inception", 2010, 148)
        };

        foreach (var item in items)
        {
            item.PrintDetails();
            Console.WriteLine();
        }
    }
}
