using Site.Model;
using Site.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(TypeServices order, int quantity)
        {
            CartLine line = lineCollection
                .Where(g => g.Order.ID == order.ID)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Order = order,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(TypeServices order)
        {
            lineCollection.RemoveAll(l => l.Order.ID == order.ID);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Order.Price * e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }

    public class CartLine
    {
        public TypeServices Order { get; set; }
        public int Quantity { get; set; }
    }
}