Console.WriteLine("Введите три курса через пробел: USD-RUB, EUR-RUB, USD-EUR");
Currency.USD_RUB = Convert.ToDouble(Console.ReadLine());
Currency.EUR_RUB = Convert.ToDouble(Console.ReadLine());
Currency.USD_EUR = Convert.ToDouble(Console.ReadLine());
CurrencyEUR c1 = new(5);
CurrencyRUB c2 = (CurrencyRUB)c1;
Console.WriteLine(c1._value);
Console.WriteLine(c2._value);


class Currency
{
    public static double USD_RUB;
    public static double EUR_RUB;
    public static double USD_EUR;
    public double _value;
}

class CurrencyEUR : Currency
{
    public CurrencyEUR(double val) => _value = val;

    public static explicit operator CurrencyEUR(CurrencyUSD val) => new(val._value / USD_EUR);
    public static explicit operator CurrencyEUR(CurrencyRUB val) => new(val._value / EUR_RUB);
}

class CurrencyUSD : Currency
{
    public CurrencyUSD(double val) => _value = val;

    public static explicit operator CurrencyUSD(CurrencyEUR val) => new(val._value * USD_EUR);
    public static explicit operator CurrencyUSD(CurrencyRUB val) => new(val._value / USD_RUB);
}

class CurrencyRUB : Currency
{
    public CurrencyRUB(double val) => _value = val;

    public static explicit operator CurrencyRUB(CurrencyUSD val) => new(USD_RUB * val._value);
    public static explicit operator CurrencyRUB(CurrencyEUR val) => new(USD_RUB * val._value);
}