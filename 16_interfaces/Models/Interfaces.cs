using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_interfaces.Models
{
    public enum PearlColor { Black, White, Pink }
    public enum PearlShape { Round, DropShaped }
    public enum PearlType { FreshWater, SaltWater }

    public interface IPearl
    {
        public int Size { get; set; }
        public PearlColor Color { get; init; }
        public PearlShape Shape { get; init; }
        public PearlType Type { get; init; }
    }

    public interface INecklace
    {
        public List<IPearl> ListOfPearls { get; set; }
        public string Name { get; set; }
    }
}
