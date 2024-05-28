using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Products
{
    internal class ConcreteProductA2 : IProductA
    {
        public void Use()
        {
            Console.WriteLine("Using Product A2");
        }
    }
}
