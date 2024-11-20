using Seido.Utilities.SeedGenerator;
using Seido.Utilities.ConsoleInput;

namespace _10_menu;

class Program
{
    public enum Season { Winter, Spring, Summer, Fall}
    static void Main(string[] args)
    {
        Console.WriteLine("10_menu");

        do
        {
            ShowMenu();

            int _menuSel;
            if (!GetMenuSelection(out _menuSel))
            {
                break;
            }

            ProcessMenuSelection(_menuSel);

        } while (true);

        Console.WriteLine("\nThank you for playing");
    }

    public static void ShowMenu()
    {
        Console.WriteLine("\n\nMenu:");
        Console.WriteLine("1 - Enter an integer");
        Console.WriteLine("2 - Enter a string");
        Console.WriteLine("3 - Enter a date and time");
        Console.WriteLine("4 - Enter an enum");
        Console.WriteLine("5 - Enter multiple input");
        Console.WriteLine("Q - Quit program");
    }

    public static bool GetMenuSelection(out int menuSelection)
    {
        if (!ConsoleInput.TryReadInt32("Enter your selection", 1, 5, out menuSelection))
        {
            return false;
        }
        return true;
    }

    private static void ProcessMenuSelection(int _menuSel)
    {
        switch (_menuSel)
        {
            case 1:
                int _intAnswer;
                if (ConsoleInput.TryReadInt32("Enter an integer", -1, 101, out _intAnswer))
                {
                    Console.WriteLine($"You entered {_intAnswer}");
                }
                break;

            case 2:
                string _strAnswer = null;
                if (ConsoleInput.TryReadString("Enter a string", out _strAnswer))
                {
                    Console.WriteLine($"You entered {_strAnswer}");
                }

                break;

            case 3:
                DateTime _dtAnswer = default;
                if (ConsoleInput.TryReadDateTime("Enter a date and time", out _dtAnswer))
                {
                    Console.WriteLine($"You entered {_dtAnswer}");
                }
                break;

            case 4:
                Season _enAnswer = default;
                if (ConsoleInput.TryReadEnum<Season>("Enter a Season", out _enAnswer))
                {
                    Console.WriteLine($"You entered {_enAnswer}");
                }
                break;

            case 5:
                Season _enAnswer1 = default;
                string _strAnswer1 = null;
                if (ConsoleInput.TryReadString("Enter first input (string)", out _strAnswer1) &&
                    ConsoleInput.TryReadEnum<Season>("Enter second input (Season)", out _enAnswer1))
                {
                    Console.WriteLine($"You entered {_enAnswer1}");
                    Console.WriteLine($"You entered {_strAnswer1}");
                }

                break;
        }
    }
}

