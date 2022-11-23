namespace Hospedagem.Models;

public class Person
{
    public Person() { }

    public Person(string name) => this.name = name;

    public Person(string name, string lastName)
    {
        this.name = name;
        this.lastName = lastName;
    }

    public string? name { get; set; }
    public string? lastName { get; set; }
    public string? nameCompleto => $"{name} {lastName}".ToUpper();
}