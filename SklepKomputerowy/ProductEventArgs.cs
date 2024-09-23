using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepKomputerowy
{
    public class ProductEventArgs : EventArgs
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }

        public ProductEventArgs(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
