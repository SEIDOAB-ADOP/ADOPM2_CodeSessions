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
        public PearlColor Color { get; set; }
        public PearlShape Shape { get; set; }
        public PearlType Type { get; set; }
    }

    public interface INecklace
    {
        public List<IPearl> ListOfPearls { get;}
        public string Name { get; set; }
        public IPearl LargestPearl { get; }
        public IPearl SmallestPearl { get; }

    }
}
