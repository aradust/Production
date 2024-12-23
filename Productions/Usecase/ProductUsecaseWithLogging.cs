using Production;

using System.ComponentModel;

/// <summary>
/// Класс с логированием вызовов методов.
/// </summary>
public class ProductionUsecaseWithLogging : ProductionUsecase
{
    private readonly string _logFilePath = "log.txt";

    public ProductionUsecaseWithLogging(IProductRepository productRepository) : base(productRepository)
    {
    }

    private void Log(string message)
    {
        File.AppendAllText(_logFilePath, $"{DateTime.Now}: {message}\n");
    }

    public override BindingList<Product> GetAllProducts()
    {
        Log("GetAllProducts: Start");
        var result = base.GetAllProducts();
        Log("GetAllProducts: End");
        return result;
    }

    public override Product GetProductById(int id)
    {
        Log($"GetProductById({id}): Start");
        var result = base.GetProductById(id);
        Log($"GetProductById({id}): End");
        return result;
    }

    public override Product AddProduct(Product product)
    {
        Log("AddProduct: Start");
        var result = base.AddProduct(product);
        Log("AddProduct: End");
        return result;
    }

    public override Product UpdateProduct(Product product)
    {
        Log("UpdateProduct: Start");
        var result = base.UpdateProduct(product);
        Log("UpdateProduct: End");
        return result;
    }

    public override ulong DeleteProduct(int Id)
    {
        Log($"DeleteProduct({Id}): Start");
        var result = base.DeleteProduct(Id);
        Log($"DeleteProduct({Id}): End");
        return result;
    }
}