# Підсистема 1
class Subsystem1:
    def operation1(self):
        print("Subsystem1: Operation1")


# Підсистема 2
class Subsystem2:
    def operation2(self):
        print("Subsystem2: Operation2")


# Підсистема 3
class Subsystem3:
    def operation3(self):
        print("Subsystem3: Operation3")


# Фасад
class Facade:
    def __init__(self):
        self.subsystem1 = Subsystem1()
        self.subsystem2 = Subsystem2()
        self.subsystem3 = Subsystem3()

    def operation_facade(self):
        print("Facade: OperationFacade")
        self.subsystem1.operation1()
        self.subsystem2.operation2()
        self.subsystem3.operation3()


# Клієнт
def main():
    facade = Facade()
    facade.operation_facade()


if __name__ == "__main__":
    main()