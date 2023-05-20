using System;

// Абстрактный продукт A
public abstract class AbstractProductA
{
    public abstract void MethodA();
}

// Абстрактный продукт B
public abstract class AbstractProductB
{
    public abstract void MethodB();
}

// Конкретный продукт A1
public class ConcreteProductA1 : AbstractProductA
{
    public override void MethodA()
    {
        Console.WriteLine("Выполняется метод MethodA в ConcreteProductA1.");
    }
}

// Конкретный продукт A2
public class ConcreteProductA2 : AbstractProductA
{
    public override void MethodA()
    {
        Console.WriteLine("Выполняется метод MethodA в ConcreteProductA2.");
    }
}

// Конкретный продукт B1
public class ConcreteProductB1 : AbstractProductB
{
    public override void MethodB()
    {
        Console.WriteLine("Выполняется метод MethodB в ConcreteProductB1.");
    }
}

// Конкретный продукт B2
public class ConcreteProductB2 : AbstractProductB
{
    public override void MethodB()
    {
        Console.WriteLine("Выполняется метод MethodB в ConcreteProductB2.");
    }
}

// Абстрактная фабрика
public abstract class AbstractFactory
{
    public abstract AbstractProductA CreateProductA();
    public abstract AbstractProductB CreateProductB();
}

// Конкретная фабрика 1
public class ConcreteFactory1 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ConcreteProductA1();
    }

    public override AbstractProductB CreateProductB()
    {
        return new ConcreteProductB1();
    }
}

// Конкретная фабрика 2
public class ConcreteFactory2 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ConcreteProductA2();
    }

    public override AbstractProductB CreateProductB()
    {
        return new ConcreteProductB2();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Создание конкретной фабрики 1
        AbstractFactory factory1 = new ConcreteFactory1();

        // Создание продуктов через фабрику 1
        AbstractProductA productA1 = factory1.CreateProductA();
        AbstractProductB productB1 = factory1.CreateProductB();

        // Выполнение методов продуктов
        productA1.MethodA();
        productB1.MethodB();

        // Создание конкретной фабрики 2
        AbstractFactory factory2 = new ConcreteFactory2();

        // Создание продуктов через фабрику 2
        AbstractProductA productA2 = factory2.CreateProductA();
        AbstractProductB productB2 = factory2.CreateProductB();

        // Выполнение методов продуктов
        productA2.MethodA();
        productB2.MethodB();

        Console.ReadLine();
    }
}
