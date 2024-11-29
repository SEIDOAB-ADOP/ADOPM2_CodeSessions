using Seido.Utilities.SeedGenerator;

namespace _17_pattern_matching.Models;

public record PearlAsRecord (int Size, PearlColor Color, PearlShape Shape, PearlType Type) : IPearl
{
    public PearlAsRecord():this(0, PearlColor.Black, PearlShape.Round, PearlType.FreshWater)
    {}
    public IPearl Seed(SeedGenerator seeder)
    { 
        return new PearlAsRecord(
            seeder.Next(5,25),
            seeder.FromEnum<PearlColor>(),
            seeder.FromEnum<PearlShape>(),
            seeder.FromEnum<PearlType>());
    }
}