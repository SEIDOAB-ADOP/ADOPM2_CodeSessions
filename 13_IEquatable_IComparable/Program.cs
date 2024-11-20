
using Seido.Utilities.SeedGenerator;

namespace _13_IEquatable_IComparable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("13_IEquatable_IComparable");

        var rnd = new SeedGenerator();
        var p1 = new csPearl();
        Console.WriteLine(p1);

        var p2 = new csPearl().Seed(rnd);
        Console.WriteLine(p2);

        var p3 = new csPearl(p2);
        Console.WriteLine(p2.Equals(p3));

        Console.WriteLine(p2 == p3);

        /*
        List<csPearl> pearls = rnd.ToList<csPearl>(100);
        pearls.Sort();
        foreach (var item in pearls)
        {
            Console.WriteLine(item);
        }
        */
    }
}

