using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_interfaces.Models
{
    public class Necklace : INecklace
    {
        public List<IPearl> ListOfPearls { get; } = new List<IPearl>();
        public string Name { get; set; }
        public IPearl LargestPearl => ListOfPearls.OrderByDescending(p => p.Size).First();
        public IPearl SmallestPearl => ListOfPearls.OrderByDescending(p => p.Size).Last();

        public Necklace(string name = null)
        {
            Name = name;   
        }
    }
}
