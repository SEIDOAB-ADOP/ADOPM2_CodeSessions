using Seido.Utilities.SeedGenerator;

namespace _17_pattern_matching.Models;

public class PearlAsClass : IPearl
{
    public int Size { get; init; }
    public PearlColor Color { get; init; }
    public PearlShape Shape { get; init; }
    public PearlType Type { get; init; }

    public decimal Price { get; set; }


    public override string ToString() => $"{GetType().Name}: {Size}mm {Color} {Shape} {Type} pearl.";

    public IPearl Seed(SeedGenerator _seeder)
    { 
        return new PearlAsClass() {
            Size = _seeder.Next(5,25),
            Color = _seeder.FromEnum<PearlColor>(),
            Shape = _seeder.FromEnum<PearlShape>(),
            Type = _seeder.FromEnum<PearlType>()
        };
    }
}