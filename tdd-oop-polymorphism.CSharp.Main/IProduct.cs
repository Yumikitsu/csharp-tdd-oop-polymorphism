using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public interface IProduct
    {
        public string name { get; set; }
        public int price { get; set; }

        public int getPrice();
        public string getName();
    }
}
