namespace BartapStatistics.Domain;

public class Person
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public User User { get; set; }
}