Person person = new Person()
{
    FirstName = "John",
    LastName = "Doe",
    Age = 44
};
Console.WriteLine(person);
public record Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int Age { get; init; }
}
