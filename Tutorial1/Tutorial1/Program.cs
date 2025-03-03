// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("Hello " +  name);

class Animal
{
    string name;
    public Animal(string name)
    {
        this.name = name; 
    }

    public string getName () {return name;}

    static void Main(string[] args)
    {
        Animal myAnimal = new Animal("Gibbs");
        Console.WriteLine(myAnimal.getName());
    }

}