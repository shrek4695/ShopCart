using System;
using System.Collections.Generic;
using System.Text;

namespace CartBooking
{
    class Cart: ICartOperations
    {
        private int CartAmount;
        private List<Product> CartItems=new List<Product>();
        public void AddItem(Product P)
        {
            try
            {
                CartItems.Add(P);
                Console.WriteLine("Products Added Successfully");
                Console.ReadKey();
                Console.Clear();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void RemoveItems(int productId, int Quantity)
        {
            try
            {
                Product P=(CartItems.Find(p => p.productId == productId));
                if (Quantity <= P.productQuantity)
                    P.productQuantity = P.productQuantity - Quantity;
                else
                    throw new Exception("Enter Valid Quantity");
                Console.WriteLine("Product of Given Quantity Removed Successfully");
                Console.ReadKey();
                Console.Clear();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void RetrievingItems()
        {
            foreach(Product index in CartItems)
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine(" Product Id="+index.productId);
                Console.WriteLine(" Product Name=" + index.productName);
                Console.WriteLine(" Product Price=" + index.productPrice);
                Console.WriteLine(" Product Quantity=" + index.productQuantity);
                Console.WriteLine("-------------------------------------------------------------------");
            }
        }
        public int GetTotalAmount()
        {
            int sum = 0;
            foreach (Product index in CartItems)
            {
                sum = sum + index.productPrice * index.productQuantity;
            }
            CartAmount = sum;
            return CartAmount;
        }

    }
}
