using System;
using Seido.Utilities.SeedGenerator;

namespace _13_IEquatable_IComparable
{
    public enum enPearlColor { Black, White, Pink }
    public enum enPearlShape { Round, DropShaped }
    public enum enPearlType { FreshWater, SaltWater }

    #region Pearl as a class
    public class csPearl : ISeed<csPearl>, IComparable<csPearl>, IEquatable<csPearl>
    {
        public int Size { get; set; }
        public enPearlColor Color { get; set; }
        public enPearlShape Shape { get; set; }
        public enPearlType Type { get; set; }
        public bool Seeded { get; set; }

        public override string ToString() => $"{Size}mm {Color} {Shape} {Type} pearl.";

        public csPearl Seed(SeedGenerator _seeder)
        {
            Size = _seeder.Next(5, 25);
            Color = _seeder.FromEnum<enPearlColor>();
            Shape = _seeder.FromEnum<enPearlShape>();
            Type = _seeder.FromEnum<enPearlType>();
            Seeded = true;

            return this;
        }

        //Implementing IComparable
        public int CompareTo(csPearl other)
        {

            if (this.Color != other.Color)
                return this.Color.CompareTo(other.Color);

            return this.Size.CompareTo(other.Size);
        }

        //Implementing IEquatable
        public bool Equals(csPearl other) => (this.Size, this.Color, this.Type, this.Shape) ==
            (other.Size, other.Color, other.Type, other.Shape);

        //Legacy compliant in IEquatable
        public override bool Equals(object other) => Equals(other as csPearl);
        public override int GetHashCode() => (this.Size, this.Color, this.Type, this.Shape).GetHashCode();

        //Operator overload
        public static bool operator ==(csPearl o1, csPearl o2) => o1.Equals(o2);
        public static bool operator !=(csPearl o1, csPearl o2) => !o1.Equals(o2);


        public csPearl() { }

        public csPearl(int _size, enPearlColor _color, enPearlShape _shape, enPearlType _type)
        {
            Size = _size;
            Color = _color;
            Shape = _shape;
            Type = _type;
        }
        public csPearl(csPearl org)
        {
            Size = org.Size;
            Color = org.Color;
            Shape = org.Shape;
            Type = org.Type;
        }
    }
    #endregion
}

