public class Wine : Collectible, IComparable
{
    public double PricePerGlass { get; set; }
    public string Country { get; set; }
    public WineType Type { get; set; }
    
    public override string CollectType => $"{Type.ToString().ToLower()} wine";

    public override string ToString() => $"{Name} ({Country})";
}