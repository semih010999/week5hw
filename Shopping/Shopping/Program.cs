using Entities;
using ShoppingDb;

ProductDb.Products.ForEach(p =>
Console.WriteLine(p.ProductName));

Console.WriteLine("------------------------------------------");

var products = ProductDb.Products;

foreach (var item in products)
{
    Console.WriteLine($"{item.ProductName,-10}"+
        $"{item.Price,-10}"+
        $"{item.Category.CategoryName,-10}");
}

Console.WriteLine("------------------------------------------");

var myCart = new Cart();
myCart.Add(
    new CartItem()
    {
        Product = ProductDb.Products[0],
        Quantity = 2
    }
);
myCart.Add(
    new CartItem()
    {
        Product = ProductDb.Products[1],
        Quantity = 3
    }
);

myCart.ShowCart();