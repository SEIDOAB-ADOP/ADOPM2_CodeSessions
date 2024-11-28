using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_interfaces.Models
{
    public class PearlAsClass:IPearl
    {
        public int Size { get; set; }
        public PearlColor Color { get; set; }
        public PearlShape Shape { get; set; }
        public PearlType Type { get; set; }

        public override string ToString() => $"{Size}mm {Color} {Shape} {Type} pearl.";
    }
    public struct PearlAsStruct : IPearl
    {
        public int Size { get; set; }
        public PearlColor Color { get; set; }
        public PearlShape Shape { get; set; }
        public PearlType Type { get; set; }

        public override string ToString() => $"{Size}mm {Color} {Shape} {Type} pearl.";
    }
}
