class Dog : Animal
{
    public string breed;

    public Dog(string name, int age, string breed) : base(name, age)
    {
        this.breed = breed;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woof");
    }
}