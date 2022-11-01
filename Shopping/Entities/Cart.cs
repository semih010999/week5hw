namespace Entities
{
    public class Cart
    {
        private List<CartItem> CartItems { get; set; }
        public Cart()
        {
            CartItems = new List<CartItem>();
        }
        public void Add(CartItem item)
        {
            CartItems.Add(item);
        }

        public void Remove(int id)
        {
            var cartitem = CartItems.Where(ci => ci.CartItemId == id).FirstOrDefault();
            CartItems.Remove(cartitem);
        }

        public void ShowCart()
        {
            foreach (var item in CartItems)
            {
                Console.WriteLine($"{item.Product.ProductName,-10}"+
                    $"{item.Quantity,-5}"+
                    $"{item.Product.Price,-10}"+
                    $"{item.Product.Price=item.Quantity,-5}");
            }
        }


    }

}
