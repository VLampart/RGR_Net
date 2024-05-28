using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    internal class ConcreteFactory2 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
