public abstract class Collectible
{
    public string Name { get; set; }
    public int YearOfOrigin { get; set; }
    public double Price { get; set; }
    public abstract string CollectType { get; }

    public double StartBidPrice => Price * 0.8;

    public override string ToString() => $"{Name}";

    public int CompareTo(object obj)
    {
        if (obj == null) return 1;
        
        Collectible otherCollectible = obj as Collectible;
        if (otherCollectible != null)
            return this.Name.CompareTo(otherCollectible?.Name);
        else
            throw new ArgumentException("Object is not a Collectible");
    }
}