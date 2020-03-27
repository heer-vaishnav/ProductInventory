using System;

namespace ProductInventory
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Inventory inventory = new Inventory("Mobile",1000);
        lable:
            Console.WriteLine("Hello...Welcome To The Store!!!");
            Console.WriteLine("Enter Your Choice:");
            Console.WriteLine("1.View Products");
            Console.WriteLine("2.Add Product");
            Console.WriteLine("3.Search");
            Console.WriteLine("4.Count");
            Console.WriteLine("5.Exit");
        
            int ch = Int16.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    inventory.List();
                    //Console.WriteLine("UserName And Password are:");
                    goto lable;

                case 2:
                    inventory.AddNewProduct();
                    //Console.WriteLine("Deposit"+acc);
                    goto lable;

                case 3:
                    inventory.Search();
                    // Console.WriteLine("Deposit" + acc);
                    goto lable;

                case 4:
                    inventory.Count();
                    // Console.WriteLine("Deposit" + acc);
                    goto lable;

                case 5:
                    break;

                default:
                    Console.WriteLine("Invalid!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
