using Seido.Utilities.SeedGenerator;

namespace _12_generics;

public class MySecrets<T, U>
{
    public T Secret1 { get; set; }
    public U Secret2 { get; set; }

    public override string ToString() => $"{Secret1}, {Secret2}";

    public string SuperDuperSecret<W>(W suffix)
        where W : new()
    {
        var new_suff = new W();
        return $"Fishing {suffix}, {new_suff}";
    }    
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("12_generics");

        var ms1 = new MySecrets<string, string>() { Secret1 = "Love", Secret2 = "Food" };
        Console.WriteLine(ms1);
        Console.WriteLine(ms1.SuperDuperSecret<bool>(true));

        var ms2 = new MySecrets<string, int>() { Secret1 = "Food", Secret2 = 42 };
        Console.WriteLine(ms2);
        Console.WriteLine(ms2.SuperDuperSecret<int>(5));

        var ms3 = new MySecrets<int, int>() { Secret1 = 3, Secret2 = 42 };
        Console.WriteLine(ms3);
        Console.WriteLine(ms3.SuperDuperSecret<int>(5));

    }
}

