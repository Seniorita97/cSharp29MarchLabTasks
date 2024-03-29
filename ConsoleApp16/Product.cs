using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Product
    {
        public int Id;
        public string BrandName;
        public string Model;
        public int Price;
        public int Cost;
        public int InCome;
        public int Count;



        public Product(int id, string brandName, string model, int price, int cost, int count)
        {
            this.Id = id;
            this.BrandName = brandName;
            this.Model = model;
            this.Price = price;
            this.Cost = cost;
            Count = count < 0 ? 0 : count;
            InCome = 0;
            Sale(50);
        }
            public void GetInfo()
            {
                Console.WriteLine($"Id: {Id}");
                Console.WriteLine($"Brand: {BrandName}");
                Console.WriteLine($"Model: {Model}");
                Console.WriteLine($"Price: {Price}$");
                Console.WriteLine($"Cost: {Cost}");
                Console.WriteLine($"Count: {Count}");
                Console.WriteLine($"Income: {InCome}");
            }
        public void Sale(int saleCount) 
        {
            if ( this.Count >= saleCount ) 
            {
                this.InCome = this.InCome + (this.Price * saleCount) - (this.Cost * saleCount);
                this.Count -= saleCount;

                Console.WriteLine("Satis ugurla yerine yetirildi");
            }
            
            else
            {
                Console.WriteLine("Satis ucun kifayet qeder mehsul yoxdur");
            }
        }
    }

}

