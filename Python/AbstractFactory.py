# Інтерфейси абстрактних продуктів
class AbstractProductA:
    def use(self):
        pass

class AbstractProductB:
    def use(self):
        pass

# Конкретні продукти
class ConcreteProductA1(AbstractProductA):
    def use(self):
        print("Using Product A1")

class ConcreteProductA2(AbstractProductA):
    def use(self):
        print("Using Product A2")

class ConcreteProductB1(AbstractProductB):
    def use(self):
        print("Using Product B1")

class ConcreteProductB2(AbstractProductB):
    def use(self):
        print("Using Product B2")

# Інтерфейс абстрактної фабрики
class AbstractFactory:
    def create_product_A(self) -> AbstractProductA:
        pass
    
    def create_product_B(self) -> AbstractProductB:
        pass

# Конкретні фабрики
class ConcreteFactory1(AbstractFactory):
    def create_product_A(self) -> ConcreteProductA1:
        return ConcreteProductA1()

    def create_product_B(self) -> ConcreteProductB1:
        return ConcreteProductB1()

class ConcreteFactory2(AbstractFactory):
    def create_product_A(self) -> ConcreteProductA2:
        return ConcreteProductA2()

    def create_product_B(self) -> ConcreteProductB2:
        return ConcreteProductB2()

# Клієнтський код
class Client:
    def __init__(self, factory: AbstractFactory):
        self.product_A = factory.create_product_A()
        self.product_B = factory.create_product_B()

    def run(self):
        self.product_A.use()
        self.product_B.use()

# Демонстрація роботи
if __name__ == "__main__":
    factory1 = ConcreteFactory1()
    client1 = Client(factory1)
    client1.run()

    factory2 = ConcreteFactory2()
    client2 = Client(factory2)
    client2.run()
