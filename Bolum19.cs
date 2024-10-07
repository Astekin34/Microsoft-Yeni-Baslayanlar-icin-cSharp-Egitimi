using System;
using System.Collections.Generic;

Console.WriteLine("Hello OOP");
var p1 = new Person("Scott", "Hansel", new DateTime(1970, 1, 1));
var p2 = new Person("David", "Howler", new DateTime(1986, 1, 1));

p1.Pets.Add(new Dog("Fred"));
p1.Pets.Add(new Dog("Barney"));

p2.Pets.Add(new Cat("Beyonce"));

List<Person> people = new List<Person> { p1, p2 };
foreach (var person in people)
{
    Console.WriteLine($"{person}");
    foreach (var pet in person.Pets)
    {
        Console.WriteLine($"    {pet} says: {pet.MakeNoise()}");
    }
}

public class Person
{
    public string First { get; }
    public string Last { get; }
    public DateTime Birthday { get; }

    public List<Pet> Pets { get; } = new();

    public Person(string firstname, string lastname, DateTime birthday)
    {
        First = firstname;
        Last = lastname;
        Birthday = birthday;
    }

    public override string ToString()
    {
        return $"Human {First}, {Last}";
    }
}

public abstract class Pet
{
    public string First { get; }

    protected Pet(string firstname)
    {
        First = firstname;
    }

    public abstract string MakeNoise();

    public override string ToString()
    {
        return $"{First}, and I am a {GetType().Name}";
    }
}

public class Cat : Pet
{
    public Cat(string firstname) : base(firstname) { }

    public override string MakeNoise() => "meow";
}

public class Dog : Pet
{
    public Dog(string firstname) : base(firstname) { }

    public override string MakeNoise() => "bark";
}
