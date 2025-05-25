namespace Rira.InternQualifierTask;

public enum Category
{
    Category1,
    Category2,
    Category3
}

public record Product
{
    public int Id { get; init; }
    public string? Name { get; init; }
    public Category Category { get; init; }
    public decimal Price { get; init; }
}