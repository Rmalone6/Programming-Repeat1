using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Item
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public Item(string name, double price,int quantity )
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return string.Format($"{Name}, {Price} - Quantity {Quantity}");
        }
    }
}
