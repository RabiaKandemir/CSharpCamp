﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + product.Name);
        }
        public void Add2(string productName,string description,double price,int stock)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + productName);
        }
    }
}
