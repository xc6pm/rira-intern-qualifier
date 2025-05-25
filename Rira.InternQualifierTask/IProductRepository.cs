namespace Rira.InternQualifierTask;

public interface IProductRepository
{
    public IEnumerable<Product> FindByCategory(Category category);

    public Product? FindMostExpensive();

    public decimal TotalValueInStock();

    public IEnumerable<IGrouping<Category, Product>> GroupByCategory();

    public decimal FindAveragePrice();
}