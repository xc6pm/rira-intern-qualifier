List<Product> products =
[
    new() { Id = 1, Name = "Product A", Category = Category.Category1, Price = 100 },
    new() { Id = 2, Name = "Product B", Category = Category.Category1, Price = 150 },
    new() { Id = 3, Name = "Product C", Category = Category.Category2, Price = 120 },
    new() { Id = 4, Name = "Product D", Category = Category.Category3, Price = 200 },
    new() { Id = 5, Name = "Product E", Category = Category.Category1, Price = 80 }
];

Console.WriteLine("Products in category 1:");
// .ToList().ForEach() would be an alternative (used for Q4) but it's preferred not to allocate a list for this one.
foreach (var product in products.Where(p => p.Category == Category.Category1))
{
    Console.WriteLine(product);
}

Console.WriteLine();

Console.WriteLine($"The most expensive product: {products.MaxBy(p => p.Price)}");

Console.WriteLine();

Console.WriteLine($"Sum of all product prices: {products.Sum(p => p.Price)}");

Console.WriteLine();

Console.WriteLine($"Products grouped by Category:{Environment.NewLine}{
    string.Join(Environment.NewLine, products
        .GroupBy(p => p.Category)
        .Select(p => string.Join(Environment.NewLine, p.Prepend<object>($"{p.Key}:")))
        .ToList())
}");

Console.WriteLine();

Console.WriteLine($"The average product price: {products.Average(p => p.Price)}");

enum Category
{
    Category1,
    Category2,
    Category3
}

record Product
{
    public int Id { get; init; }
    public string? Name { get; init; }
    public Category Category { get; init; }
    public decimal Price { get; init; }
}