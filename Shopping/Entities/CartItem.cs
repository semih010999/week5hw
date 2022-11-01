using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public Product Product { get; set; }
        public uint Quantity { get; set; } 


    }
}
