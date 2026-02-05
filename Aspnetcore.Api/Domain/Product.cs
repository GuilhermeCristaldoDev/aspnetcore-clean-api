namespace AspnetCore.Api.Domain;

internal class Product
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsActive { get; set; }

    public Product (string name, decimal price, bool isActive)
    {
        Name = name;
        Price = price;
        IsActive = isActive;
    }
}