namespace AspnetCore.Api.Domain;

internal class Costumer
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public string Email {get; set;}

    public Costumer (string name, string email)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
    }
}