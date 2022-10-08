Car c1 = new("Mercedes", "internal combustion engine", 320);
Car c2 = new("Bmw", "internal combustion engine", 285);
Car c3 = new("Audi", "internal combustion engine", 325);
Car c4 = new("Tesla", "electric engine", 280);
CarsCatalog cat = new(c1, c2, c3, c4);
Console.WriteLine(c1);
Console.WriteLine(c2 == c3);
Console.WriteLine(cat[0]);

class Car : IEquatable<Car>
{
    public string Name { get; }
    public string Engine { get; }
    public int MaxSpeed { get; }

    public Car(string name, string engine, int speed) => (Name, Engine, MaxSpeed) = (name, engine, speed);

    public override string? ToString()
    {
        return string.IsNullOrEmpty(Name) ? base.ToString() : Name;
    }

    public bool Equals(Car? obj)
    {
        if (obj is not null) return (Name == obj.Name && Engine == obj.Engine && MaxSpeed == obj.MaxSpeed);
        return false;
    }
}

class CarsCatalog
{
    private Car[] _cars;

    public CarsCatalog(params Car[] cars) => _cars = cars;
    public string this[int index] => $"{_cars[index].Name} with {_cars[index].Engine}";
}