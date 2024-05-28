using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Clients
{
    internal class Client
    {
        private IProductA _productA;
        private IProductB _productB;

        public Client(IAbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }

        public void Run()
        {
            _productA.Use();
            _productB.Use();
        }
    }
}
