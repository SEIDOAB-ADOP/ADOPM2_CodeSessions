﻿using System;
using Seido.Utilities.SeedGenerator;

namespace _10a_menu
{
    public enum PearlColor { Black, White, Pink }
    public enum PearlShape { Round, DropShaped }
    public enum PearlType { FreshWater, SaltWater }

    #region Pearl as a class
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
            Size = _seeder.Next(5, 25);
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
    #endregion

    #region Pearl as a record
    public record PearlAsRecord(int Size, PearlColor Color, PearlShape Shape, PearlType Type)
    {
        public override string ToString() => $"{Size}mm {Color} {Shape} {Type} pearl.";

        //Your own constructor, must call this(record properties...)
        public PearlAsRecord(SeedGenerator _seeder) : this(

            _seeder.Next(5, 25),
            _seeder.FromEnum<PearlColor>(),
            _seeder.FromEnum<PearlShape>(),
            _seeder.FromEnum<PearlType>())
        { }
    }
    #endregion
}

