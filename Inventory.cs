using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInventory
{
    public class Inventory
    {
        int price;
        string productName;
        Dictionary<string, int> product = new Dictionary<string, int>();

        public Inventory(string productName,int price)
        {
            this.productName = productName;
            this.price = price;
        }

        public void List()
        {
            product.Add("TV", 2000);
            product.Add("Shampoo", 150);
            foreach (KeyValuePair<string, int> item in product)
            {
                Console.WriteLine("{0}-{1}",
                          item.Key, item.Value);
            }

            Console.WriteLine("");
        }

        public void AddNewProduct()
        {
            //Dictionary<string, string> Users = new Dictionary<string, string>();
            Console.WriteLine("How many products you want to add?:");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter Product Name :");
                productName = Console.ReadLine();
                Console.WriteLine("Enter Price:");
                price = Int32.Parse(Console.ReadLine());

                product.Add(productName, price);
                //Console.WriteLine("Your Product is " + productName + " and Price is " + price);
                foreach (KeyValuePair<string, int> item in product)
                {
                    Console.WriteLine("{0}-{1}",
                              item.Key, item.Value);
                }
                Console.WriteLine("");

            }
           //Console.WriteLine(product.Count);
        }

        public void Search()
        {
            Console.WriteLine("Enter ProductName you want to search:");

            string prod = Console.ReadLine();
            if (product.ContainsKey("" + prod))
            {
                Console.WriteLine("Product Found :" + prod);
            }
            else
            {
                Console.WriteLine("Product is not Available");
            }
            Console.WriteLine("");
        }


        public void Count()
        {
            Console.WriteLine("Total Products:" + product.Count);
        }  
    }
}
