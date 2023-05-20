using System;

// Интерфейс, который ожидается клиентом
public interface ITarget
{
    void Request();
}

// Адаптируемый класс
public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Выполняется SpecificRequest в Adaptee.");
    }
}

// Адаптер
public class Adapter : ITarget
{
    private Adaptee adaptee;

    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    public void Request()
    {
        Console.WriteLine("Выполняется Request через адаптер.");
        adaptee.SpecificRequest();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);

        target.Request();

        Console.ReadLine();
    }
}
