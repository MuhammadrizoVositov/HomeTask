
using System.Text.Json;
List<Product> products = new List<Product>()
{
    new Product { Id = 0, Name = "Gosht", Category = "Qoyniki", Price = 90000 },
    new Product { Id = 1, Name = "Gosht", Category = "Molniki", Price = 70000 },
    new Product { Id = 2, Name = "Gosht", Category = "Tovuqniki", Price = 450000 },
    new Product { Id = 3, Name = "Gosht", Category = "Baliqniki", Price = 120000 },
};

var json = JsonSerializer.Serialize(products);

File.WriteAllText("C:\\Users\\rizo2\\source\\repos\\3-thrd_Lesson\\JsonWrite\\products.json", json);
Console.WriteLine("Quyidagi funksiyalardan birini tanlang:\n1.Create\n2.Update\n3.Get");
while (true)
{
    int n = int.Parse(Console.ReadLine());

    if(n == 1)
    {
        //post yani listga qo'shish
        Console.WriteLine("Nom kiriting:");
        var name = Console.ReadLine();

        Console.WriteLine("Kategoriya kiriting:");
        var category = Console.ReadLine();

        Console.WriteLine("Narx kiriting:");
        var price = int.Parse(Console.ReadLine());

        var newProduct = new Product()
        {
            Id = n,
            Name = name,
            Category = category,
            Price = price
        };
        products.Add(newProduct);

        json = JsonSerializer.Serialize(products);
        File.WriteAllText("C:\\Users\\rizo2\\source\\repos\\3-thrd_Lesson\\JsonWrite\\products.json", json);
      
    }
}


class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public int Price { get; set; }
}


