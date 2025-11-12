using System;
using Seido.Utilities.SeedGenerator;

namespace _08_inheritance
{
    public enum GrapeType { Reissling, Tempranillo, Chardonay, Shiraz, CabernetSavignoin, Syrah }
    public enum WineType { Red, White, Rose }
    public enum Country { Germany, France, Spain }

    public class Wine
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

        public Wine() { }
        public Wine(SeedGenerator _seeder)
        {
            string[] _names = "Chattaux de bueff, Chattaux de paraply, PutiPuti".Split(", ");
            Name = _names[_seeder.Next(0, _names.Length)];

            GrapeType = _seeder.FromEnum<GrapeType>();
            WineType = _seeder.FromEnum<WineType>();
            Country = _seeder.FromEnum<Country>();
            Price = _seeder.Next(50, 150);
        }
        public Wine(string _name, Country _country, GrapeType _grapetype,
            WineType _wineType, decimal _price)
        {
            Name = _name;
            GrapeType = _grapetype;
            WineType = _wineType;
            Country = _country;
            Price = _price;
        }
        public Wine(Wine org)
        {
            Name = org.Name;
            GrapeType = org.GrapeType;
            WineType = org.WineType;
            Country = org.Country;
            Price = org.Price;
        }
    }
}

