public class ComicBook : Collectible, IComparable
{
    public string Publisher { get; set; }
    public string Author { get; set; }

    public override string CollectType => "comic book";

    public override string ToString() => $"{Name} ({Author})";
}