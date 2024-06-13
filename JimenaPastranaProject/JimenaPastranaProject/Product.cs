using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimenaPastranaProject
{
    public class Product
    {
        public string Product_ID { get; set; }
        public string Product_Name { get; set; }
        public double Product_Price { get; set; }

        public Product(string product_ID, string product_Name, double product_Price)
        {
            Product_ID = product_ID;
            Product_Name = product_Name;
            Product_Price = product_Price;
        }

    }
}
