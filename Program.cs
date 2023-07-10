using Dotnet_Cap3;

var products = new List<Product>
{
    new Product{Name="Milk", Price=1.2, CategoryId=1},
    new Product{Name="Orange Juice", Price=3.2, CategoryId=3},
    new Product{Name="Milka Biscuits", Price=3.2, CategoryId=2},
    new Product{Name="Tea biscuits", Price=3.2, CategoryId=2},
    new Product{Name="Coca Cola", Price=3.2, CategoryId=3},
    new Product{Name="Parmigiano", Price=5.0, CategoryId=1},
};

var categories = new List<Category>
{
    new Category{Id=1, Name="Dairy"},
    new Category{Id=2, Name="Biscuits"},
    new Category{Id=3, Name="Drinks"}
};

var results = products.Join(
    categories,
    product => product.CategoryId,
    category => category.Id,
    (product, category) => new
    {
        Name = product.Name,
        Price = product.Price,
        Category = category.Name
    });

foreach (var product in results)
{
    Console.WriteLine($"Name: {product.Name}");
    Console.WriteLine($"Price: {product.Price}");
    Console.WriteLine($"Category: {product.Category}");
    Console.WriteLine();
};