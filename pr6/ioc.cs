using System;

// Интерфейс сервиса
public interface IService
{
    void Execute();
}

// Реализация сервиса
public class Service : IService
{
    public void Execute()
    {
        Console.WriteLine("Выполняется сервис.");
    }
}

// Класс, требующий использования сервиса
public class Client
{
    private readonly IService _service;

    // Конструктор, принимающий сервис через параметр
    public Client(IService service)
    {
        _service = service;
    }

    public void Run()
    {
        Console.WriteLine("Клиент запущен.");
        _service.Execute();
    }
}

// Главный класс программы
public class Program
{
    public static void Main(string[] args)
    {
        // Создание экземпляра сервиса
        IService service = new Service();

        // Создание экземпляра клиента и передача сервиса через конструктор
        Client client = new Client(service);

        // Запуск клиента
        client.Run();

        Console.ReadLine();
    }
}
