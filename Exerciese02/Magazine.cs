public class Magazine : LibraryItem
{
    public int IssueNumber { get; set; }

    public Magazine(int id, string title, int yearPublished, int issueNumber)
        : base(id, title, yearPublished)
    {
        IssueNumber = issueNumber;
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"Issue Number: {IssueNumber}");
    }
}