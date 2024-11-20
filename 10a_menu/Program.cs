using Seido.Utilities.SeedGenerator;
using Seido.Utilities.ConsoleInput;
namespace _10a_menu;

class Program
{
    public enum Season { Winter, Spring, Summer, Fall }
    public class AppData
    {
        public Necklace Necklace { get; set; }
        public PearlAsClass Pearl { get; set; }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("10a_menu");

        //This instance will be valid for all menu iterations in the do..while loop
        //could also have been stataic globals in Program class, but his is better
        var AppData = new AppData
        {
            Necklace = new Necklace("Pretty necklace"),
            Pearl = new PearlAsClass()
        };
            
        do
        {
            ShowMenu();

            int _menuSel;
            if (!GetMenuSelection(out _menuSel))
            {
                break;
            }

            //Only if menu item selected do we get here
            ProcessMenuSelection(_menuSel, AppData);

            //Clear the console output before menu presentations 
            Clear();

        } while (true);

        Console.WriteLine("Bye, thank you for playing!");
    }

    private static void Clear()
    {
        Console.WriteLine("Press a key to get back to meny");
        Console.ReadKey();
        Console.Clear();
    }

    private static void ProcessMenuSelection(int _menuSel, AppData _appData)
    {
        var rnd = new SeedGenerator();

        switch (_menuSel)
        {
            case 1:

                //Create a specific Pearl
                int _size = default;
                PearlColor _color = default;
                PearlShape _shape = default;
                PearlType _type = default;
                if (ConsoleInput.TryReadInt32("Enter pearl size", 5, 11, out _size) &&
                    ConsoleInput.TryReadEnum<PearlColor>("Enter pearl color", out _color) &&
                    ConsoleInput.TryReadEnum<PearlShape>("Enter pearl shape", out _shape) &&
                    ConsoleInput.TryReadEnum<PearlType>("Enter pearl type", out _type))
                {
                    _appData.Pearl = new PearlAsClass(_size, _color, _shape, _type);
                    Console.WriteLine(_appData.Pearl);
                }
                break;

            case 2:

                //Create a random Pearl
                _appData.Pearl = new PearlAsClass(rnd);
                Console.WriteLine(_appData.Pearl);

                break;

            case 3:

                //Add the created Pearl to a Necklace
                _appData.Necklace.ListOfPearls.Add(_appData.Pearl);
                Console.WriteLine(_appData.Necklace);

                break;
            case 4:

                Console.WriteLine(_appData.Necklace);
                break;

        }
    }

    private static bool GetMenuSelection(out int menuSelection)
    {
        bool _continue;
        if (!ConsoleInput.TryReadInt32("Enter your selection", 1, 4, out menuSelection))
        {
            _continue = false;
        }
        else
        {
            _continue = true;
        }

        return _continue;
    }

    private static void ShowMenu()
    {
        Console.WriteLine("\n\nMenu:");
        Console.WriteLine("1 - Create a specific Pearl");
        Console.WriteLine("2 - Create a random Pearl");
        Console.WriteLine("3 - Add a the Pearl to a Necklace");
        Console.WriteLine("4 - Present the Necklace");

        Console.WriteLine("Q - Quit program");
    }
}

