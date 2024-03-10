
partial class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal("Generic Animal", 5);
        myAnimal.MakeSound(); 
        Console.WriteLine($"Name: {myAnimal.name}, Age: {myAnimal.age}");

        Dog myDog = new Dog("Buddy", 3, "Golden Retriever");
        myDog.MakeSound();
        Console.WriteLine($"Name: {myDog.name}, Age: {myDog.age}, Breed: {myDog.breed}");
    }
}

