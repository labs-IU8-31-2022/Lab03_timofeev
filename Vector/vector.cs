Vector t1 = new(4, 2, 2);
Vector t2 = new(7, 3, 3);
Vector t3 = new(11, 5, 5);
Console.WriteLine(t1 + t2 == t3);
Vector t4 = new(28, 6, 6);
Console.WriteLine(t1 * t2 == t4);
Vector t5 = new(14, 6, 6);
Console.WriteLine(t2 * 2 == t5);
Console.WriteLine(t1 > t2);


struct Vector
{
    private int x;
    private int y;
    private int z;

    public Vector(int X, int Y, int Z)
    {
        x = X;
        y = Y;
        z = Z;
    }

    public static Vector operator +(Vector vec1, Vector vec2)
    {
        return new Vector(vec1.x + vec2.x, vec1.y + vec2.y, vec1.z + vec2.z);
    }
    
    public static Vector operator *(Vector vec1, Vector vec2)
    {
        return new Vector(vec1.x * vec2.x, vec1.y * vec2.y, vec1.z * vec2.z);
    }
    
    public static Vector operator *(Vector vec1, int num)
    {
        return new Vector(vec1.x * num, vec1.y * num, vec1.z * num);
    }

    private static decimal Calc(Vector vec)
    {
        return (decimal)Math.Pow(Math.Pow(vec.x, 2) + Math.Pow(vec.y, 2) + Math.Pow(vec.z, 2), 0.5);
    }

    public static bool operator ==(Vector vec1, Vector vec2)
    {
        return Calc(vec1) == Calc(vec2);
    }

    public static bool operator !=(Vector vec1, Vector vec2)
    {
        return !(vec1 == vec2);
    }

    public static bool operator <(Vector vec1, Vector vec2)
    {
        return Calc(vec1) < Calc(vec2);
    }
    
    public static bool operator >(Vector vec1, Vector vec2)
    {
        return Calc(vec1) > Calc(vec2);
    }
}