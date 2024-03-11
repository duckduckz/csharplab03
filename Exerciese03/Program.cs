class Program03
{
    static void Main(string[] args)
    {
        var collectibles = new List<Collectible>
        {
            new Wine { Name = "Chateau Margaux", YearOfOrigin = 2015, Price = 650, Country = "France", Type = WineType.RED },
            new PostStamp { Name = "Blue & Brown Issue", YearOfOrigin = 1920, Price = 5000, Image = "blue-brown.jpg" },
            new ComicBook { Name = "The Amazing Spider-Man", YearOfOrigin = 1962, Price = 11000, Publisher = "Marvel Comics", Author = "Stan Lee" },

        };

        collectibles.Sort();

        foreach (var item in collectibles)
        {
            Console.WriteLine($"{item}: {item.CollectType}, Start Bid Price: {item.StartBidPrice:C}");
        }
    }
}
