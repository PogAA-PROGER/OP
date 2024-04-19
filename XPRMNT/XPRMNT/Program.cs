using System;

// Абстрактный класс для работы с денежными суммами
public abstract class Currency
{
    protected double amount;
    protected double KursRub;

    public Currency(double amount, double KursRub)
    {
        this.amount = amount;
        this.KursRub = KursRub;
    }

    public abstract double ConvertToRubles();
    public abstract void Display();
}

// Класс для работы с долларами
public class Dollar : Currency
{
    public Dollar(double amount, double KursRub) : base(amount, KursRub)
    {
    }

    public override double ConvertToRubles()
    {
        return amount * KursRub;
    }

    public override void Display()
    {
        Console.WriteLine($"Сумма в долларах: {amount}, Сумма в рублях: {ConvertToRubles()}");
    }
}

// Класс для работы с евро
public class Euro : Currency
{
    public Euro(double amount, double KursRub) : base(amount, KursRub)
    {
    }

    public override double ConvertToRubles()
    {
        return amount * KursRub;
    }

    public override void Display()
    {
        Console.WriteLine($"Сумма в евро: {amount}, Сумма в рублях: {ConvertToRubles()}");
    }
}

// Класс для работы с фунтами стерлингов
public class Pound : Currency
{
    public Pound(double amount, double KursRub) : base(amount, KursRub)
    {
    }

    public override double ConvertToRubles()
    {
        return amount * KursRub;
    }

    public override void Display()
    {
        Console.WriteLine($"Сумма в фунтах стерлингов: {amount}, Сумма в рублях: {ConvertToRubles()}");
    }
}

// Класс для хранения кошелька
public class Purse
{
    private Currency[] currencies;

    public Purse(int capacity)
    {
        currencies = new Currency[capacity];
    }

    public void AddCurrency(Currency currency, int index)
    {
        if (index >= 0 && index < currencies.Length)
        {
            currencies[index] = currency;
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    public void Display()
    {
        foreach (Currency currency in currencies)
        {
            if (currency != null)
            {
                currency.Display();
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в коневертер валюты!");
        Console.WriteLine("Введите количество и обменный курс для каждой валюты:");

        double amount, exchangeRate;

        Console.WriteLine("Введите количество долларов:");
        while (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
        {
            Console.WriteLine("Неправильный ввод. Введите положительное число:");
        }

        Console.WriteLine("Введите обменный курс по отношению к рублю для доллара:");
        while (!double.TryParse(Console.ReadLine(), out exchangeRate) || exchangeRate <= 0)
        {
            Console.WriteLine("Неправильный ввод. Введите положительное число:");
        }
        Dollar dollar = new Dollar(amount, exchangeRate);

        Console.WriteLine("Введите количество евро:");
        while (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
        {
            Console.WriteLine("Неправильный ввод. Введите положительное число:");
        }

        Console.WriteLine("Введите обменный курс по отношению к рублю для евро:");
        while (!double.TryParse(Console.ReadLine(), out exchangeRate) || exchangeRate <= 0)
        {
            Console.WriteLine("Неправильный ввод. Введите положительное число:");
        }
        Euro euro = new Euro(amount, exchangeRate);

        Console.WriteLine("Введите количество фунтов стерлингов:");
        while (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
        {
            Console.WriteLine("Неправильный ввод. Введите положительное число:");
        }

        Console.WriteLine("Введите обменный курс по отношению к рублю для фунта стерлтнгов:");
        while (!double.TryParse(Console.ReadLine(), out exchangeRate) || exchangeRate <= 0)
        {
            Console.WriteLine("Неправильный ввод. Введите положительное число:");
        }
        Pound pound = new Pound(amount, exchangeRate);

        Purse purse = new Purse(3);
        purse.AddCurrency(dollar, 0);
        purse.AddCurrency(euro, 1);
        purse.AddCurrency(pound, 2);

        // Вывод информации о кошельке
        Console.WriteLine("\nВ вашем кошельке: ");
        purse.Display();
    }
}