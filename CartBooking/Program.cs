using System;
using System.Collections.Generic;
using System.Text;

namespace CartBooking
{
    class Program
    {
        public static void Main()
        {
            Product p1 = new Product("pen", 101, 5, 10);
            Product p2 = new Product("book", 102, 10, 5);
            Product p3 = new Product("Bottle", 103, 2, 10);
            Cart cartobject = new Cart();
            cartobject.AddItem(p1);
            cartobject.AddItem(p2);
            cartobject.AddItem(p3);
            cartobject.RetrievingItems();
            int Amount=cartobject.GetTotalAmount();
            Console.WriteLine("Amount="+Amount);
            cartobject.RemoveItems(101, 2);
            cartobject.RemoveItems(102, 5);
            cartobject.RetrievingItems();
            Amount=cartobject.GetTotalAmount();
            Console.WriteLine("Amount="+Amount);
            Console.ReadLine();
        }
    }
}
