using Seido.Utilities.SeedGenerator;

namespace _06_embedded_list;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("06_embedded_list");

        var rnd = new SeedGenerator();

        var p1 = new PearlAsClass();
        Console.WriteLine(p1);

        var p2 = new PearlAsClass(rnd);
        Console.WriteLine(p2);

        var pr = new PearlAsRecord(rnd);
        Console.WriteLine(pr);

        var pr_copy = pr with { Color = PearlColor.Pink };
        Console.WriteLine(pr_copy);
 
        var n = new Necklace(3, "African with Pearls as a class");
        Console.WriteLine(n);

        var n2 = new Necklace("Another halsband", p1, p2);
        Console.WriteLine(n2);
       
        var n1 = new Necklace1(15, "European with Pearls as a record");
        Console.WriteLine(n1);
    }
}

