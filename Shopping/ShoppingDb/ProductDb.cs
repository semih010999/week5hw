using Entities;

namespace ShoppingDb
{
    public static class ProductDb
    {
            public static List<Product> Products { get; set; }
            static ProductDb()
            {
                Products = new List<Product>()
                    {
                        new Product() { Id = 1, ProductName ="hp",Price=15000,Category=new Category(){ CategoryId=1,CategoryName="electronic"}},
                        new Product() { Id = 2, ProductName ="msi",Price=15000,Category=new Category(){ CategoryId=1,CategoryName="electronic"}},
                        new Product() { Id = 3, ProductName ="asus",Price=15000,Category=new Category(){ CategoryId=1,CategoryName="electronic"}},

                    };
            }
            
        
    }
}