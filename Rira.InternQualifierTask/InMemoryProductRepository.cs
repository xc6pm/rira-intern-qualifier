namespace Rira.InternQualifierTask;

public class InMemoryProductRepository : IProductRepository
{
    private readonly List<Product> _products =
    [
        new() { Id = 1, Name = "Product A", Category = Category.Category1, Price = 100 },
        new() { Id = 2, Name = "Product B", Category = Category.Category1, Price = 150 },
        new() { Id = 3, Name = "Product C", Category = Category.Category2, Price = 120 },
        new() { Id = 4, Name = "Product D", Category = Category.Category3, Price = 200 },
        new() { Id = 5, Name = "Product E", Category = Category.Category1, Price = 80 }
    ];

    public IEnumerable<Product> FindByCategory(Category category) =>
        _products.Where(p => p.Category == Category.Category1);

    public Product? FindMostExpensive() => _products.MaxBy(p => p.Price);

    public decimal TotalValueInStock() => _products.Sum(p => p.Price);

    public IEnumerable<IGrouping<Category, Product>> GroupByCategory() =>
        _products.GroupBy(p => p.Category);

    public decimal FindAveragePrice() => _products.Average(p => p.Price);
}