using Seido.Utilities.SeedGenerator;

namespace _04_record_vs_class;

public enum PearlColor { Black, White, Pink }
public enum PearlShape { Round, DropShaped }
public enum PearlType { FreshWater, SaltWater }

public class PearlAsClass
{
    public int Size { get; init; }
    public PearlColor Color { get; init; }
    public PearlShape Shape { get; init; }
    public PearlType Type { get; init; }

    public override string ToString() => $"{Size}mm {Color} {Shape} {Type} pearl.";

    public PearlAsClass() { }
    public PearlAsClass(SeedGenerator _seeder)
    {
        Size = _seeder.Next(5,25);
        Color = _seeder.FromEnum<PearlColor>();
        Shape = _seeder.FromEnum<PearlShape>();
        Type = _seeder.FromEnum<PearlType>();
    }
    public PearlAsClass(int _size, PearlColor _color, PearlShape _shape, PearlType _type)
    {
        Size = _size;
        Color = _color;
        Shape = _shape;
        Type = _type;
    }
    public PearlAsClass(PearlAsClass org)
    {
        Size = org.Size;
        Color = org.Color;
        Shape = org.Shape;
        Type = org.Type;
    }
}

public record PearlAsRecord (int Size, PearlColor Color, PearlShape Shape, PearlType Type)
{
    //Your own constructor, must call this(record properties...)
    public PearlAsRecord(SeedGenerator _seeder) : this (
   
        _seeder.Next(5, 25),
        _seeder.FromEnum<PearlColor>(),
        _seeder.FromEnum<PearlShape>(),
        _seeder.FromEnum<PearlType>())
    { }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("04_record_vs_clas");

        var rnd = new SeedGenerator();
        var p = new PearlAsClass(rnd);

        Console.WriteLine(p);

        var pc = new PearlAsClass(p) { Size = 5 };

        Console.WriteLine(pc);

        Console.WriteLine("\n\n");
        var pr = new PearlAsRecord(25,PearlColor.White, PearlShape.DropShaped, PearlType.FreshWater);
        Console.WriteLine(pr);

        var pr_c = pr with { Size = 5 };
        Console.WriteLine(pr_c);

        var rnd_p = new PearlAsRecord(rnd);
        Console.WriteLine(rnd_p);
    }
}

