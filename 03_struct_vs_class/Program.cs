using Seido.Utilities.SeedGenerator;
namespace _03_struct_vs_class;


public enum GrapeType { Reissling, Tempranillo, Chardonay, Shiraz, CabernetSavignoin, Syrah }
public enum WineType { Red, White, Rose }
public enum Country { Germany, France, Spain }

public struct WineAsStruct
{
    public string Name { get; }

    public Country Country { get; }
    public WineType WineType { get; }
    public GrapeType GrapeType { get; }

    public decimal Price { get; set; }

    public override string ToString()
    {
        var s = $"Wine {Name} from {Country} is {WineType} and made from grapes {GrapeType}. The price is {Price:N2} Sek";
        return s;
    }

    public WineAsStruct() { }
    public WineAsStruct(SeedGenerator _seeder)
    {
        Name = _seeder.FromString("Chattaux de bueff, Chattaux de paraply, PutiPuti");

        GrapeType = _seeder.FromEnum<GrapeType>();
        WineType = _seeder.FromEnum<WineType>();
        Country = _seeder.FromEnum<Country>();
        Price = _seeder.NextDecimal(50, 150);
    }
    public WineAsStruct(string _name, Country _country, GrapeType _grapetype,
        WineType _wineType, decimal _price)
    {
        Name = _name;
        GrapeType = _grapetype;
        WineType = _wineType;
        Country = _country;
        Price = _price;
    }
    public WineAsStruct(WineAsStruct org)
    {
        Name = org.Name;
        GrapeType = org.GrapeType;
        WineType = org.WineType;
        Country = org.Country;
        Price = org.Price;
    }
}

public class WineAsClass : IEquatable<WineAsClass>
{
    public string Name { get; }

    public Country Country { get; }
    public WineType WineType { get; }
    public GrapeType GrapeType { get; }

    public decimal Price { get; set; }

    
    #region Implementing IEquatable 
    public bool Equals(WineAsClass other) => (Name, Country, GrapeType, WineType) ==
            (other.Name, other.Country, other.GrapeType, other.WineType);

    public override bool Equals(object obj) => Equals(obj as WineAsClass);
    public override int GetHashCode() => (Name, Country, GrapeType, WineType).GetHashCode();
    #endregion

    #region operator overloading
    public static bool operator == (WineAsClass w1, WineAsClass w2) => w1.Equals(w2);
    
    public static bool operator !=(WineAsClass w1, WineAsClass w2) => !w1.Equals(w2);    
    #endregion
    

    public override string ToString()
    {
        var s = $"Wine {Name} from {Country} is {WineType} and made from grapes {GrapeType}. The price is {Price:N2} Sek";
        return s;
    }



    public WineAsClass() { }
    public WineAsClass(SeedGenerator _seeder)
    {
        string[] _names = "Chattaux de bueff, Chattaux de paraply, PutiPuti".Split(", ");
        Name = _names[_seeder.Next(0, _names.Length)];

        GrapeType = _seeder.FromEnum<GrapeType>();
        WineType = _seeder.FromEnum<WineType>();
        Country = _seeder.FromEnum<Country>();
        Price = _seeder.Next(50, 150);
    }
    public WineAsClass(string _name, Country _country, GrapeType _grapetype,
        WineType _wineType, decimal _price)
    {
        Name = _name;
        GrapeType = _grapetype;
        WineType = _wineType;
        Country = _country;
        Price = _price;
    }
    public WineAsClass(WineAsClass org)
    {
        Name = org.Name;
        GrapeType = org.GrapeType;
        WineType = org.WineType;
        Country = org.Country;
        Price = org.Price;
    }
}


class Program
{
    static void Main(string[] args)
    {
        var cs_w1 = new WineAsClass("Nice evening", Country.Spain,
            GrapeType.Tempranillo, WineType.Red, 80M);

        var cs_w2 = new WineAsClass("Nice evening", Country.Spain,
            GrapeType.Tempranillo, WineType.Red, 80M);

        Console.WriteLine($"class Equals: {cs_w1.Equals(cs_w2)}");
        Console.WriteLine($"class Equals: {cs_w1 == cs_w2}");
        System.Console.WriteLine(cs_w1);

        Object o1 = cs_w1;
        Object o2 = cs_w2;
        Console.WriteLine($"class Equals: {o1.Equals(o2)}");

        Console.WriteLine("\n");
        var cs_w3 = cs_w1;
        Console.WriteLine($"class Equals: {cs_w1.Equals(cs_w3)}");
        //Console.WriteLine($"class Equals: {cs_w1 == cs_w3}");

/*
        Console.WriteLine($"wine csw1: {cs_w1}");
        Console.WriteLine($"wine csw3: {cs_w3}");
        if (cs_w1 == cs_w3)
        {
            Console.WriteLine("Both wines are equal");
        }

        Console.WriteLine("\n");
        var cs_w4 = new WineAsClass(cs_w1);

        cs_w4.Price = 30M;
        Console.WriteLine($"class Equals: {cs_w1.Equals(cs_w4)}");
        Console.WriteLine($"class Equals: {cs_w1 == cs_w4}");

        Console.WriteLine($"wine csw1: {cs_w1}");
        Console.WriteLine($"wine csw4: {cs_w4}");
        if (cs_w1 == cs_w4)
        {
            Console.WriteLine("Both wines are equal");
        }
        else
        {
            Console.WriteLine("Both wines are NOT equal");
        }
        */

    }
}

