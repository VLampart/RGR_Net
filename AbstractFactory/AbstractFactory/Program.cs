using System;
using AbstractFactory.Clients;
using AbstractFactory.Interfaces;
using AbstractFactory.Factories;
namespace AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        IAbstractFactory factory1 = new ConcreteFactory1();
        Client client1 = new Client(factory1);
        client1.Run();

        IAbstractFactory factory2 = new ConcreteFactory2();
        Client client2 = new Client(factory2);
        client2.Run();
    }
}
