using System;
using System.Collections.Generic;
using System.Text;

namespace CartBooking
{
    class Product
    {
        public int productId;
        public int productQuantity;
        public int productPrice;
        public String productName;

        public Product(String name, int id,int quantity,int price)
        {
            productName = name;
            productId = id;
            productQuantity = quantity;
            productPrice = price;
        }
    }
}
