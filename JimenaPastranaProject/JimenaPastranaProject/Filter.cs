using JimenaPastranaProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JimenaPastranaProject
{
    public class Filter
    {
        public List<Product> Matches { get; set; }
        public Filter()
        {
            Matches = new List<Product>();
        }

        public List<Product> SearchMethod(string codeInsert)
        {
            Matches.Clear();
            foreach (Product product in ListOfProducts.Inventory)
            {
                if (product.Product_ID.Contains(codeInsert))
                {
                    Matches.Add(product);
                }
            }
            return Matches;
        }
    }
}

