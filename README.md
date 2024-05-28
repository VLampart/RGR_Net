# Розрахунково-графічна робота 611пст 11 варіант

## Creational pattern: [Abstract factory](https://en.wikipedia.org/wiki/Abstract_factory_pattern).

Abstract Factory — це паттерн проектування, який надає інтерфейс для створення сімейств взаємозалежних або пов'язаних об'єктів без необхідності вказувати їх конкретні класи. Його структура допомагає створювати об'єкти, які є частинами одного цілого або одного "сімейства".

Ось основні компоненти Abstract Factory паттерну:
    AbstractFactory (Абстрактна фабрика):
        Визначає інтерфейс для створення абстрактних продуктів (об'єктів).
        Наприклад, IFurnitureFactory з методами createChair(), createSofa().
    ConcreteFactory (Конкретна фабрика):
        Реалізує інтерфейс AbstractFactory і створює конкретні продукти.
        Наприклад, ModernFurnitureFactory реалізує createChair() і createSofa() для створення сучасних меблів, а VictorianFurnitureFactory створює вікторіанські меблі.
    AbstractProduct (Абстрактний продукт):
        Визначає інтерфейс для класу продуктів.
        Наприклад, Chair з методом sitOn(), Sofa з методом lieOn().
    ConcreteProduct (Конкретний продукт):
        Реалізує інтерфейс AbstractProduct.
        Наприклад, ModernChair реалізує sitOn() для сучасного стільця, а VictorianChair реалізує sitOn() для вікторіанського стільця.
    Client (Клієнт):
        Використовує тільки інтерфейси AbstractFactory та AbstractProduct.
        Наприклад, клас FurnitureShop, який отримує фабрику в конструкторі і використовує її для створення меблів.

Шаблони проектування описують шаблон Abstract factory як «інтерфейс для створення сімейств пов’язаних або залежних об’єктів без визначення їхніх конкретних класів».

### UML-діаграма

classDiagram
    direction TB

    class AbstractFactory {
        <<interface>>
        +createProductA(): AbstractProductA
        +createProductB(): AbstractProductB
    }

    class ConcreteFactory1 {
        +createProductA(): AbstractProductA
        +createProductB(): AbstractProductB
    }

    class ConcreteFactory2 {
        +createProductA(): AbstractProductA
        +createProductB(): AbstractProductB
    }

    AbstractFactory <|.. ConcreteFactory1
    AbstractFactory <|.. ConcreteFactory2

    class AbstractProductA {
        <<interface>>
    }

    class ConcreteProductA1 {
    }

    class ConcreteProductA2 {
    }

    AbstractProductA <|.. ConcreteProductA1
    AbstractProductA <|.. ConcreteProductA2

    class AbstractProductB {
        <<interface>>
    }

    class ConcreteProductB1 {
    }

    class ConcreteProductB2 {
    }

    AbstractProductB <|.. ConcreteProductB1
    AbstractProductB <|.. ConcreteProductB2

    ConcreteFactory1 --> ConcreteProductA1 : createProductA()
    ConcreteFactory1 --> ConcreteProductB1 : createProductB()
    ConcreteFactory2 --> ConcreteProductA2 : createProductA()
    ConcreteFactory2 --> ConcreteProductB2 : createProductB()

### Діаграма взаємодії

sequenceDiagram
    participant Client
    participant AbstractFactory
    participant ConcreteFactory1
    participant AbstractProductA
    participant ConcreteProductA1
    participant AbstractProductB
    participant ConcreteProductB1

    Client ->> AbstractFactory: createProductA()
    activate AbstractFactory
    AbstractFactory ->> ConcreteFactory1: createProductA()
    activate ConcreteFactory1
    ConcreteFactory1 -->> Client: ConcreteProductA1
    deactivate ConcreteFactory1
    deactivate AbstractFactory

    Client ->> AbstractFactory: createProductB()
    activate AbstractFactory
    AbstractFactory ->> ConcreteFactory1: createProductB()
    activate ConcreteFactory1
    ConcreteFactory1 -->> Client: ConcreteProductB1
    deactivate ConcreteFactory1
    deactivate AbstractFactory

    Client ->> ConcreteProductA1: useProductA()
    activate ConcreteProductA1
    deactivate ConcreteProductA1

    Client ->> ConcreteProductB1: useProductB()
    activate ConcreteProductB1
    deactivate ConcreteProductB1


## Structural pattern: [Facade](https://en.wikipedia.org/wiki/Facade_pattern)

Патерн Facade — це шаблон проектування програмного забезпечення, який зазвичай використовується в об’єктно-орієнтованому програмуванні. Подібно до фасаду в архітектурі, це об’єкт, який служить переднім інтерфейсом, що маскує більш складний основний або структурний код.

Основні компоненти патерну Facade:
	Фасад (Facade):
		Головний компонент патерну, який надає простий інтерфейс взаємодії з підсистемою.
		Делегує запити клієнтів відповідним об'єктам усередині підсистеми.
	Підсистема (Subsystem):
		Набір класів, методів та функцій, які виконують роботу.
		Підсистема не знає про існування фасаду та працює незалежно від нього.

### UML-діаграма
classDiagram
    class Facade {
        +operation1()
        +operation2()
        +operation3()
    }
    class Subsystem1 {
        +operation1()
    }
    class Subsystem2 {
        +operation2()
    }
    class Subsystem3 {
        +operation3()
    }
    class Client {
        +run()
    }

    Facade ..> Subsystem1
    Facade ..> Subsystem2
    Facade ..> Subsystem3
    Client --> Facade

### Діаграма взаємодії

sequenceDiagram
    participant Client
    participant Facade
    participant Subsystem1
    participant Subsystem2
    participant Subsystem3

    Client ->> Facade: operation1()
    activate Facade
    Facade ->> Subsystem1: operation1()
    activate Subsystem1
    Subsystem1 -->> Facade: response1
    deactivate Subsystem1
    Facade -->> Client: response1
    deactivate Facade

    Client ->> Facade: operation2()
    activate Facade
    Facade ->> Subsystem2: operation2()
    activate Subsystem2
    Subsystem2 -->> Facade: response2
    deactivate Subsystem2
    Facade -->> Client: response2
    deactivate Facade

    Client ->> Facade: operation3()
    activate Facade
    Facade ->> Subsystem3: operation3()
    activate Subsystem3
    Subsystem3 -->> Facade: response3
    deactivate Subsystem3
    Facade -->> Client: response3
    deactivate Facade

## Behavioral pattern [Memento](https://en.wikipedia.org/wiki/Memento_pattern)

Патерн memento - це патерн проектування програмного забезпечення, який розкриває приватний внутрішній стан об'єкта. Одним із прикладів його використання є відновлення об'єкта до попереднього стану (відкат), іншим - версіонування, третім - кастомна серіалізація.

Основні компоненти патерну Мemento:
    Originator: Це клас або об'єкт, стан якого потрібно зберігати. Він також може відновлювати свій стан з мементо.
    Memento: Це об'єкт, який зберігає стан "Творця". Зазвичай мементо є імутабельним об'єктом (тобто, один раз створений, він не може бути змінений).
    Caretaker: Це клас, який відповідає за збереження мементо. Він не знає деталей стану "Творця", але відповідає за збереження і повернення мементо.

### UML-діаграма

classDiagram
    class Originator {
        + setState(state: State)
        + getState(): State
        - state: State
        + createMemento(): Memento
        + restoreMemento(memento: Memento)
    }
    class Memento {
        - state: State
        + getState(): State
        + setState(state: State)
    }
    class Caretaker {
        - mementos: Memento[]
        + addMemento(memento: Memento)
        + getMemento(index: int): Memento
    }
    class State {
        - stateData: string
        + setStateData(data: string)
        + getStateData(): string
    }

    Originator "1" -- "1" Memento : creates >
    Originator "1" -- "0..*" Memento : "uses >"
    Originator "1" -- "1" Caretaker : "uses >"
    State "1" -- "1" Memento : "stores >"

### Діаграма взаємодії

sequenceDiagram
    participant Client
    participant Originator
    participant Memento
    participant Caretaker
    participant State

    Client ->> Originator: setState(newState)
    Originator ->> State: setStateData(newStateData)
    Note over State: Збереження нового стану
    Originator ->> Memento: createMemento()
    Memento -->> Originator: newMemento
    Originator ->> Caretaker: addMemento(newMemento)

    Client ->> Originator: setState(newState2)
    Originator ->> State: setStateData(newStateData2)
    Note over State: Збереження нового стану
    Originator ->> Memento: createMemento()
    Memento -->> Originator: newMemento2
    Originator ->> Caretaker: addMemento(newMemento2)

    Client ->> Caretaker: getMemento(index)
    Caretaker ->> Originator: getMemento(index)
    Originator -->> Memento: storedMemento
    Memento -->> Originator: storedMemento
    Originator ->> State: getStateData()
    Note over State: Відновлення стану
    State -->> Originator: currentState

    Client ->> Caretaker: getMemento(index)
    Caretaker ->> Originator: getMemento(index)
    Originator -->> Memento: storedMemento2
    Memento -->> Originator: storedMemento2
    Originator ->> State: getStateData()
    Note over State: Відновлення стану
    State -->> Originator: currentState2

## Concurrency pattern [Read write lock](https://en.wikipedia.org/wiki/Readers%E2%80%93writer_lock)

Read-write lock - це механізм синхронізації доступу до ресурсу, який дозволяє багатьом потокам одночасно отримувати доступ до ресурсу для читання, але лише одному потоку для запису.

Структура read-write lock зазвичай має наступний вигляд:
Число читачів (readers_count): Це ціле число, яке відстежує кількість потоків, які в даний момент читають ресурс.
Флаг блокування на запис (write_lock): Це булева змінна, яка вказує, чи зайнятий ресурс для запису. Якщо вона встановлена (true), то жоден потік не може здійснювати запис.
Семафор читачів (readers_semaphore): Це семафор, який регулює доступ читачів до ресурсу. Він дозволяє багатьом потокам одночасно отримувати доступ для читання.
Семафор запису (write_semaphore): Це семафор, який регулює доступ до ресурсу для запису. Він дозволяє лише одному потоку отримати доступ для запису, коли немає активних читачів.
Механізм блокування (mutex): Це блокування, яке використовується для захисту внутрішніх даних read-write lock від одночасного доступу з різних потоків.

### UML-діаграма

classDiagram
    class ReadWriteLock {
        +readLock(): void
        +readUnlock(): void
        +writeLock(): void
        +writeUnlock(): void
    }

    class Reader {
        +read(lock: ReadWriteLock): void
    }

    class Writer {
        +write(lock: ReadWriteLock): void
    }

    class Client {
        +performRead(lock: ReadWriteLock): void
        +performWrite(lock: ReadWriteLock): void
    }

    Reader --|> ReadWriteLock
    Writer --|> ReadWriteLock
    Client --|> ReadWriteLock

### Діаграма взаємодії

sequenceDiagram
    participant Client
    participant ReadWriteLock
    participant Reader
    participant Writer

    Client->>ReadWriteLock: performRead()
    ReadWriteLock->>Reader: readLock()
    activate Reader
    Reader->>ReadWriteLock: readUnlock()
    deactivate Reader
    ReadWriteLock-->>Client: Read operation completed

    Client->>ReadWriteLock: performWrite()
    ReadWriteLock->>Writer: writeLock()
    activate Writer
    Writer->>ReadWriteLock: writeUnlock()
    deactivate Writer
    ReadWriteLock-->>Client: Write operation completed

