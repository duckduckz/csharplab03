public class PostStamp : Collectible, IComparable
{
    public string Image { get; set; }

    public override string CollectType => "post stamp";
}