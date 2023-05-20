using System;

public abstract class AbstractClass
{
    // Шаблонный метод, определяющий общую структуру алгоритма
    public void TemplateMethod()
    {
        StepOne();
        StepTwo();
        StepThree();
    }

    // Абстрактные методы, которые должны быть реализованы в подклассах
    protected abstract void StepOne();
    protected abstract void StepTwo();

    // Метод с реализацией по умолчанию
    protected virtual void StepThree()
    {
        Console.WriteLine("AbstractClass: Выполняется шаг три (реализация по умолчанию).");
    }
}

public class ConcreteClassA : AbstractClass
{
    protected override void StepOne()
    {
        Console.WriteLine("ConcreteClassA: Выполняется шаг один.");
    }

    protected override void StepTwo()
    {
        Console.WriteLine("ConcreteClassA: Выполняется шаг два.");
    }
}

public class ConcreteClassB : AbstractClass
{
    protected override void StepOne()
    {
        Console.WriteLine("ConcreteClassB: Выполняется шаг один.");
    }

    protected override void StepTwo()
    {
        Console.WriteLine("ConcreteClassB: Выполняется шаг два.");
    }

    protected override void StepThree()
    {
        Console.WriteLine("ConcreteClassB: Выполняется шаг три (переопределение по умолчанию).");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Выполнение ConcreteClassA:");
        AbstractClass classA = new ConcreteClassA();
        classA.TemplateMethod();

        Console.WriteLine();

        Console.WriteLine("Выполнение ConcreteClassB:");
        AbstractClass classB = new ConcreteClassB();
        classB.TemplateMethod();

        Console.ReadLine();
    }
}
