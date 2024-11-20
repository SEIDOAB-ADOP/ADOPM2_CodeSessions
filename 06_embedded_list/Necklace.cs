using System;
using Seido.Utilities.SeedGenerator;

namespace _06_embedded_list
{
    #region Necklace using Pearl as a class
    public class Necklace
	{
        public List<PearlAsClass> ListOfPearls { get; set; } = new List<PearlAsClass>();
        public string Name { get; set; }

        public override string ToString()
        {
            string sRet = $"\n{Name}:";
            foreach (var item in ListOfPearls)
            {
                sRet += $"\n{item.ToString()}";
            }
            return sRet;
        }

        public Necklace(int nrPearls, string name)
		{
            Name = name;
            var rnd = new SeedGenerator();
            for (int i = 0; i < nrPearls; i++)
            {
                ListOfPearls.Add(new PearlAsClass(rnd));
            }
        }
        public Necklace(string name, PearlAsClass _p1, PearlAsClass _p2)
        {
            Name = name;
            ListOfPearls.Add(_p1);
            ListOfPearls.Add(_p2);
        }
    }
    #endregion

    #region Necklace using Pearl as a record
    public class Necklace1
    {
        public List<PearlAsRecord> ListOfPearls { get; set; } = new List<PearlAsRecord>();
        public string Name { get; set; }

        public override string ToString()
        {
            string sRet = $"\n{Name}:";
            foreach (var item in ListOfPearls)
            {
                sRet += $"\n{item}";
            }
            return sRet;
        }

        public Necklace1(int nrPearls, string name)
        {
            Name = name;
            var rnd = new SeedGenerator();
            for (int i = 0; i < nrPearls; i++)
            {
                ListOfPearls.Add(new PearlAsRecord(rnd));
            }
        }
    }
    #endregion
}

