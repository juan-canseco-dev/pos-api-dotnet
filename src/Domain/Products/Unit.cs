
using POS.Domain.Abstractions;

namespace POS.Domain.Products;

public class Unit : Entity<int>
{
    public string? Name { get; set; }
    private Unit() { }
}
