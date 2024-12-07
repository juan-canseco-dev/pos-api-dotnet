using POS.Domain.Abstractions;

namespace POS.Domain.Products;

public class Category : Entity<int>
{
    public string? Name { get; set; }
    private Category() { }
}
