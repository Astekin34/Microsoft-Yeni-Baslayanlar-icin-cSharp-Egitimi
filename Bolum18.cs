using Systems;
using Systems.Linq;

// Nesne Odaklı Programlama (OOP)
var p1 = new person("Scott", "Hanselman", new Dateonly(1970,1,1));
var p2 = new person("David", "Howler", new Dateonly(1970,1,1));

List<Person> people = [p1, p2];
Console.WriteLine(people.Count);

public class Person
{
  public Person(string firstname, string lastname, DateOnly birthday)
  {
    public string First { get; } = firstname;
    public string Last { get; } = lastname;
    public DateOnly Birthday { get; } = birthday;
  } 
}