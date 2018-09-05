using System;
using System.Collections.Generic;
using System.Text;

namespace CartBooking
{
    interface ICartOperations
    {
        void AddItem(Product P);
        void RemoveItems(int productId, int Quantity);
        void RetrievingItems();
        int GetTotalAmount();
    }
}
