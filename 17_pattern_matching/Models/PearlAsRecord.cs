using Seido.Utilities.SeedGenerator;

namespace _17_pattern_matching.Models;

public record PearlAsRecord (int Size, PearlColor Color, PearlShape Shape, PearlType Type) : IPearl
{
    public PearlAsRecord():this(default, default, default, default)
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