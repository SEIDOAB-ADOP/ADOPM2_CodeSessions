namespace _01_class_basics;

class Program
{
    public class Stock
    {
        private decimal _price;
        public decimal Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price cannot be 0 or negative");
                }
                else
                {
                    _price = value;
                }
            }
        }


        public int Amount { get; set; } = 0;

        public string Name { get; init; }

        public decimal TotValue()
        {
            var _amount = Price * Amount;
            return Price * Amount;
        }
        
        public override string ToString()
        {
            var _s = $"My {Name} portfolio is worth {TotValue():N2} Sek";
            return _s;
        }

        public Stock()
        {
            Name = "Volvo";
            Price = 35.30M;
            Amount = 1000;
        }
        public Stock(string _name, decimal _price, int _amount)
        {
            Name = _name;
            Price = _price;
            Amount = _amount;
        }
        public Stock(string _name, decimal _price)
        {
            Name = _name;
            Price = _price;
            Amount = 0;
        }
    }


    static void Main(string[] args)
    {
        Console.WriteLine("01_class_basics");
        var stock1 = new Stock();
        Console.WriteLine(stock1);

        var stock2 = new Stock("SAS", 2.35M, 100);
        Console.WriteLine(stock2);

        var stock3 = new Stock("Atlas Copco", 21.75M);
        Console.WriteLine(stock3);

        var stock4 = new Stock() {Price = 100.0M, Name = "GameStop"};
        Console.WriteLine(stock4);

        stock4.Price = -5.00M;
        Console.WriteLine(stock4);

    }
}

