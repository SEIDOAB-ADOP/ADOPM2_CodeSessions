using Seido.Utilities.SeedGenerator;

namespace _17_pattern_matching.Models;

public enum PearlColor { Black, White, Pink }
public enum PearlShape { Round, DropShaped }
public enum PearlType { FreshWater, SaltWater }

public interface IPearl
{
    public int Size { get; init; }
    public PearlColor Color { get; init; }
    public PearlShape Shape { get; init; }
    public PearlType Type { get; init; }

    public IPearl Seed(SeedGenerator seeder);
}