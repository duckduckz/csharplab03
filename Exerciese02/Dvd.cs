public class DVD : LibraryItem
{
    public int Duration { get; set; } // Duration in minutes

    public DVD(int id, string title, int yearPublished, int duration)
        : base(id, title, yearPublished)
    {
        Duration = duration;
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"Duration: {Duration} minutes");
    }
}