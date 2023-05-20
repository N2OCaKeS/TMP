using System;

// Интерфейс посетителя
public interface IVisitor
{
    void Visit(ElementA elementA);
    void Visit(ElementB elementB);
}

// Интерфейс элемента, принимающего посетителя
public interface IElement
{
    void Accept(IVisitor visitor);
}

// Конкретные элементы
public class ElementA : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void OperationA()
    {
        Console.WriteLine("Выполняется операция A в ElementA.");
    }
}

public class ElementB : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void OperationB()
    {
        Console.WriteLine("Выполняется операция B в ElementB.");
    }
}

// Конкретный посетитель
public class ConcreteVisitor : IVisitor
{
    public void Visit(ElementA elementA)
    {
        Console.WriteLine("Посещение ElementA.");
        elementA.OperationA();
    }

    public void Visit(ElementB elementB)
    {
        Console.WriteLine("Посещение ElementB.");
        elementB.OperationB();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IElement elementA = new ElementA();
        IElement elementB = new ElementB();

        IVisitor visitor = new ConcreteVisitor();

        elementA.Accept(visitor);
        elementB.Accept(visitor);

        Console.ReadLine();
    }
}
