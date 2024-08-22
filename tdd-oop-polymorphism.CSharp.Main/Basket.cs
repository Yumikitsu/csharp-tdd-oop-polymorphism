﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        private List<IProduct> _products = new List<IProduct>();

        public List<IProduct> products { get { return _products; } }

        public void add(IProduct product)
        {
            this._products.Add(product);
        }

        public int getTotal() 
        {
            return _products.Sum(x => x.price); 
        }

        public bool isInBasket(String name)
        {
            foreach (IProduct p in _products)
            {
                if (p.name == name) return true;
            }
            return false;
        }
    }
}
