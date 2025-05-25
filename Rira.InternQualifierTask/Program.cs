using Rira.InternQualifierTask;

IProductRepository productRepository = new InMemoryProductRepository();

Console.WriteLine("Products in category 1:");
foreach (var product in productRepository.FindByCategory(Category.Category1))
{
    Console.WriteLine(product);
}

Console.WriteLine();

Console.WriteLine($"The most expensive product: {productRepository.FindMostExpensive()}");

Console.WriteLine();

Console.WriteLine($"Sum of all product prices: {productRepository.TotalValueInStock()}");

Console.WriteLine();

// A loop like the one in Q1 is preferred with regard to performance and clarity, but this is more idiomatic:
Console.WriteLine($"Products grouped by Category:{Environment.NewLine}{
    string.Join(Environment.NewLine,
        productRepository
            .GroupByCategory()
            .Select(g => string.Join(Environment.NewLine, g.Prepend<object>($"{g.Key}:"))))
}");

Console.WriteLine();

Console.WriteLine($"The average product price: {productRepository.FindAveragePrice()}");