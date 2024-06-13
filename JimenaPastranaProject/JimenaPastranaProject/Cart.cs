using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimenaPastranaProject
{
    public class Cart
    {
        public List<(Product, int amount)> AddedItems { get; set; }
        public double CalculateTotal()
        {
            return AddedItems.Sum(item => item.Item1.Product_Price * item.Item2);
        }


        public Cart()
        {
            AddedItems = new List<(Product, int amount)>();
        }

    }
}
