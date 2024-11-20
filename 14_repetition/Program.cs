namespace _14_repetition;

class Program
{
    public enum TreasureType { Dagger, Sword, Diamond, Rubin}
    public class Treasure
    {
        public TreasureType Type { get; set; }
        public int Points { get; set; }

        public  virtual string Greeting()
        {
            return $"Treassure valid {Points} points";
        }

    }

    public class Weapon : Treasure
    {
        public bool IsSharp { get; set; }

        public override string Greeting()
        {
            return $"Weapon valid {Points} points is much better, and it is {IsSharp}";
        }

        public Weapon(TreasureType _type)
        {
            if (_type == TreasureType.Dagger || _type == TreasureType.Sword)
            {
                this.Type = _type;
                this.Points = 50;
            }
            else
            {
                throw new Exception("Not a weapon");
            }
        } 
    }
    public class Gem : Treasure
    {
        public bool IsBig { get; set; }

        public new string Greeting()
        {
            return $"Gem is {IsBig}";
        }

        public Gem(TreasureType _type)
        {
            if (_type == TreasureType.Diamond || _type == TreasureType.Rubin)
            {
                this.Type = _type;
                this.Points = 150;
            }
            else
            {
                throw new Exception("Not a Gem");
            }
        }
    }

    public class TreasureChest
    {
        private List<Treasure> treasures { get; set; } = new List<Treasure>();

        public void Add(Treasure t) => treasures.Add(t);
        public int Count => treasures.Count;

        public Treasure this[int idx] => treasures[idx];

    }

    static void Main(string[] args)
    {
        Console.WriteLine("14_repetition");

        #region polymorfism
        var tc = new TreasureChest();
        tc.Add(new Weapon(TreasureType.Dagger));
        tc.Add(new Gem(TreasureType.Diamond));

        /*
        foreach (var item in tc.treasures)
        {
            Console.WriteLine(item.Greeting());
        }
        */

        for (int r = 0; r < tc.Count; r++)
        {
            Console.WriteLine(tc[r].Greeting());
        }
        #endregion

        #region Tuples
        //Initialize several variables
        (int i, decimal d, string s) = (4, 3.5M, "Hello");
        Console.WriteLine(i);

        //Name and group variables
        (int i, decimal d, string s) t = (4, 3.5M, "Hello");
        Console.WriteLine(t.i);

        //Easy equality
        if (t == (1, 4.7M, "Goodbye"))
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not Equal");
        }

        int k = 4;
        decimal m = 3.5M;
        string v = "Hello";
        if ((k, m, v) == (i, d, s))
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not Equal");
        }

        var book = ABook();
        Console.WriteLine(book.Title);
        #endregion
    }

    public static (string Author, string Title, decimal Price) ABook()
    {
        return ("Mark Twain", "Huckleberry Finn", 12.50M);
    }
}

