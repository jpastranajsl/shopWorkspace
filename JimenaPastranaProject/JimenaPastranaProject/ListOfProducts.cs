using System;
using System.Collections.Generic;
using System.IO;

namespace JimenaPastranaProject
{
    public static class ListOfProducts
    {
        public static List<Product> Inventory { get; set; }

        static ListOfProducts()
        {
            Inventory = new List<Product>();
        }

        public static void ReadFile(string fileName)
        {
            string input = string.Empty;
            FileStream stream = File.Open(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            while (!reader.EndOfStream)
            {
                input = reader.ReadLine();

                // Split the input line by commas
                string[] values = input.Split(',');

                // make sure that the line has at least three values
                if (values.Length >= 3)
                {
                    string product_id = values[0];
                    string product_name = values[1];
                    string priceString = values[2];

                    //convert the priceString to a double
                    if (double.TryParse(priceString, out double product_price))
                    {
                        Inventory.Add(new Product(product_id, product_name, product_price));
                    }
                    else
                    {
                        Console.WriteLine($"Error converting price '{priceString}' to double.");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid line: {input}");
                }
            }
            reader.Close();
        }
    }
}
