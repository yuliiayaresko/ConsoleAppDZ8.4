using System;


interface IPricing
{
    void SetPrice(double price);
    void ApplyDiscount(string discount);
}


interface IPromocode
{
    void ApplyPromocode(string promocode);
}

interface ISizable
{
    void SetSize(byte size);
}


interface IColorable
{
    void SetColor(byte color);
}

class Book : IPricing
{
    private double price;

    public void SetPrice(double price)
    {
        this.price = price;
        Console.WriteLine($"Встановлено ціну книги: {price}");
    }

    public void ApplyDiscount(string discount)
    {
        Console.WriteLine($"Знижка '{discount}' застосована до книги.");
    }
}

class Clothing : IPricing, IColorable, ISizable
{
    private double price;
    private byte color;
    private byte size;

    public void SetPrice(double price)
    {
        this.price = price;
        Console.WriteLine($"Встановлено ціну одягу: {price}");
    }

    public void ApplyDiscount(string discount)
    {
        Console.WriteLine($"Знижка '{discount}' застосована до одягу.");
    }

    public void SetColor(byte color)
    {
        this.color = color;
        Console.WriteLine($"Колір одягу встановлено: {color}");
    }

    public void SetSize(byte size)
    {
        this.size = size;
        Console.WriteLine($"Розмір одягу встановлено: {size}");
    }
}

// Тестування
class Program
{
    static void Main(string[] args)
    {
        
        Book book = new Book();
        book.SetPrice(150.0);
        book.ApplyDiscount("10%");

        
        Clothing jacket = new Clothing();
        jacket.SetPrice(300.0);
        jacket.ApplyDiscount("20%");
        jacket.SetColor(5); 
        jacket.SetSize(42); 

        Console.ReadKey();
    }
}
//порушено принцип розділення інтерфейсу 
