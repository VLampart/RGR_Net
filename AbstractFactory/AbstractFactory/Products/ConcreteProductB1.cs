using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Products
{
    internal class ConcreteProductB1 : IProductB
    {
        public void Use()
        {
            Console.WriteLine("Using Product B1");
        }
    }
}
