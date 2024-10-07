var p1 = new Person("Scott", "Hansel",new DateOnly(1970,1,1));
var p2 = new Person("David", "Howler",new DateOnly(1986,1,1));

p1.Pets.Add(new Dog("Fred"));
p1.Pets.Add(new Dog("Barney"));

p2.Pets.Add(new Cat("Beyonce"));

List<Person>() people = [p1, p2];
foreach (var person in people)
{        
    Console.WriteLine($"{person}");
    foreach (var pet in person.Pets)
    {
        Console.WriteLine($"    {pet}");
    }
}
public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string First { get; } = firstname;
    public string Last { get; } = lastname;
    public Dateonly Birthday { get; } = birthday;

    public List<Pet> Pets { get; } = new();
}

public abstract class Pet(string firstname)
{
    public string first { get; } = firstname;

    public abstract string MakeNoise();
}
public class Cat(string firstname) : Pet(firstname)
{
    public string MakeNoise() => "meow";
}

public class Dog(string firstname) : Pet(firstname)
{
    public string MakeNoise() => "bark";
}  