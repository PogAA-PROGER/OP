using System.Collections.Specialized;
using System.Reflection.Metadata.Ecma335;
string sravn (Money m1, Money m2)
{
    if  (m1.rub > m2.rub)
    {
        return "Первая сумма больше";
    }
    else if(m1.rub == m2.rub)
    {
        if (m1.kop > m2.kop)
        {
            return "Первая сумма больше";
        }
        else if (m1.kop == m2.kop)
        {
            return "Суммы равны";
        }
    }
    else
    {
        return "Вторая сумма больше";
    }
    return "Вторая сумма больше";
}
Console.WriteLine("Задание 1");
Console.WriteLine("Введите первую сумму (сначала кол-во рублей, затем кол-во копеек)");
long rub1 = 0;
while (true)
{
    long a;
    bool result = long.TryParse(Console.ReadLine(), out a);
    if (result == false | a < 0)
    {
        Console.WriteLine("Введите не отрицательное кол-во рублей");
    }
    else
    {
        rub1 = a;
        break;
    }
}
int kop1 = 0;
while (true)
{
    int a;
    bool result = int.TryParse(Console.ReadLine(), out a);
    if (result == false | a < 0 | a >= 100)
    {
        Console.WriteLine("Введите не отрицательное кол - во копеек, возможно вы ввели число больше 100");
    }
    else
    {
        kop1 = a;
        break;
    }
}
Console.WriteLine("Введите вторую сумму (сначала кол-во рублей, затем кол-во копеек)");
long rub2 = 0;
while (true)
{
    long a;
    bool result = long.TryParse(Console.ReadLine(), out a);
    if (result == false | a < 0)
    {
        Console.WriteLine("Введите не отрицательное кол-во рублей");
    }
    else
    {
        rub2 = a;
        break;
    }
}
int kop2 = 0;
while (true)
{
    int a;
    bool result = int.TryParse(Console.ReadLine(), out a);
    if (result == false | a < 0 | a >= 100)
    {
        Console.WriteLine("Введите не отрицательное кол - во копеек, возможно вы ввели число больше 100");
    }
    else
    {
        kop2 = a;
        break;
    }
}
Money money1 = new Money(rub1, kop1);
Money money2 = new Money(rub2, kop2);
Money slgh = money1 + money2;
Money vcht = money1 - money2;
Money przvd = money1 * 14.8;
Money przvdm = money1 * money2;
Money dln = money1 / 12.8;

Console.WriteLine($"Сумма 1: {money1}");
Console.WriteLine($"Сумма 2: {money2}");
Console.WriteLine($"Cложение: {slgh}");
Console.WriteLine($"Вычитание: {vcht}");
Console.WriteLine($"Произведение: {przvdm}");
Console.WriteLine(sravn(money1, money2));
Console.WriteLine("\n \n");


Console.WriteLine("Задание 2");
Console.WriteLine("Введите название товара");
string nazv = Console.ReadLine();
Console.WriteLine("Введите цену за еденицу товара товара");
int price;
while (true)
{
    int a;
    bool result = int.TryParse(Console.ReadLine(), out a);
    if(result ==  false | a < 0)
    {
        Console.WriteLine("Введите не отрицательную цену");
    }
    else
    {
        price = a; break;
    }

}
Console.WriteLine("Введите кол-во едениц товара");
int quant;
while (true)
{
    int a;
    bool result = int.TryParse(Console.ReadLine(), out a);
    if (result == false | a < 0)
    {
        Console.WriteLine("Введите не отрицательную цену");
    }
    else
    {
        quant = a; break;
    }

}
Goods tovar = new Goods(nazv, DateTime.Now, price, quant, "22852");
Console.Write($"Товар до изменений и его стоимость :");
Console.WriteLine(tovar.GetCost());
Console.WriteLine($"Название: {tovar.name} Дата добавления: {tovar.date} цена: {tovar.price} Количество: {tovar.quantity} Номер накладной: {tovar.nakl}");
Console.WriteLine("Введите новую цену товара ");
int n;
while (true)
{
    int a;
    bool result = int.TryParse(Console.ReadLine(), out a);
    if (result == false | a < 0)
    {
        Console.WriteLine("Введите не отрицательную цену");
    }
    else
    {
        n = a; break;
    }

}
Console.WriteLine("Введите новое кол-во товара ");
int n1;
while (true)
{
    int a;
    bool result = int.TryParse(Console.ReadLine(), out a);
    if (result == false | a < 0)
    {
        Console.WriteLine("Введите не отрицательную цену");
    }
    else
    {
        n1 = a; break;
    }

}
tovar.ChangePrice(n);
tovar.DQuantity(n1);
Console.Write($"Товар после изменений и его стоимость :");
Console.WriteLine(tovar.GetCost());
Console.WriteLine($"Название: {tovar.name} Дата добавления: {tovar.date} цена: {tovar.price} Количество: {tovar.quantity} Номер накладной: {tovar.nakl}");


class Goods
{
    public string name;
    public DateTime date;
    public int price;
    public int quantity;
    public string nakl;
    public Goods(string name, DateTime date, int price, int quantity, string nakl)
    {
        this.name = name;
        this.date = date;
        this.price = price;
        this.quantity = quantity;
        this.nakl = nakl;
    }
    public string GetName => name;
    public DateTime Date => date;
    public int GetPrice => price;
    public int GetQuantity => quantity;
    public string GetNakl => nakl;
    public void ChangePrice(int newPrice)
    {
        if (newPrice > 0)
            price = newPrice;
    }

    public void DQuantity(int n)
    {
        if (n > 0)
            quantity = n;
    }

    public String GetCost()
    {
        return Convert.ToString(price * quantity);
    }
}
public class Money
{
    public long rub;
    public int kop;
    public Money(long ruble, int kopey)
    {
        rub = ruble;
        kop = kopey;
    }
    public override string ToString() => $"{rub} руб. {kop} коп.";
    static public Money operator +(Money left, Money right)
    {
        long Trub = left.rub + right.rub;
        int Tkop = left.kop + right.kop;
        while (Tkop >= 100)
        {
            Trub++;
            Tkop -= 100;
        }
        return new Money(Trub, Tkop);
    }
    static public Money operator -(Money left, Money right)
    {
        long Trub = left.rub - right.rub;
        int Tkop = left.kop - right.kop;
        if (right.kop > left.kop)
        {
            Trub--;
            Tkop = (right.kop - left.kop);
        }
        return new Money(Trub, Tkop);
    }
    static public Money operator *(Money money1, double a)
    {
        int b = (int)money1.rub * 100 + money1.kop;
        long Trub = (long)(a * b) / 100;
        int Tkop = (int)((a * b) % 100);
        return new Money(Trub, Tkop);
    }
    static public Money operator *(Money money1, Money money2)
    {
        int a = (int)money1.rub * 100 + money1.kop;
        int b = (int)money2.rub * 100 + money2.kop;
        long Trub = (a * b) / 10000;
        int Tkop = ((a * b) % 10000) / 100;
        return new Money(Trub, Tkop);
    }
    static public Money operator /(Money money1, double a)
    {
        int b = (int)money1.rub * 100 + money1.kop;
        long Trub = (long)(b / a) / 100;
        int Tkop = (int)((b / a) % 100);
        return new Money(Trub, Tkop);
    }
}