using System;
using System.Collections;

// Коллекция, для которой будет реализован итератор
public class MyCollection : IEnumerable
{
    private object[] items;

    public MyCollection()
    {
        items = new object[3];
        items[0] = "Item 1";
        items[1] = "Item 2";
        items[2] = "Item 3";
    }

    public IEnumerator GetEnumerator()
    {
        return new MyIterator(items);
    }
}

// Итератор для коллекции
public class MyIterator : IEnumerator
{
    private object[] items;
    private int position = -1;

    public MyIterator(object[] items)
    {
        this.items = items;
    }

    public bool MoveNext()
    {
        position++;
        return position < items.Length;
    }

    public void Reset()
    {
        position = -1;
    }

    public object Current
    {
        get { return items[position]; }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyCollection collection = new MyCollection();
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}
