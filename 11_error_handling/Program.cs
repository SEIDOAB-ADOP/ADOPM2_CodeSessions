using Seido.Utilities.ConsoleInput;
using Seido.Utilities.SeedGenerator;
namespace _11_error_handling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("11_error_handling");
        try
        {
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
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine("No more chances for you my friend");
        }
        Console.WriteLine("\nThank you for playing");
    }

    public static void ShowMenu()
    {
        Console.WriteLine("\n\nMenu:");
        Console.WriteLine("1 - Good Choice");
        Console.WriteLine("2 - DO NOT SELECT THIS");
        Console.WriteLine("Q - Quit program");
    }

    public static bool GetMenuSelection(out int menuSelection)
    {
        if (!ConsoleInput.TryReadInt32("Enter your selection", 1, 4, out menuSelection))
        {
            return false;
        }
        return true;
    }

    private static void ProcessMenuSelection(int _menuSel)
    {
        try
        {
            switch (_menuSel)
            {
                case 1:
                    Console.WriteLine($"Good Choise: Everything is OK!");
                    break;

                case 2:
                    //var res = SomethingCanGoWrong(100, 0); //Will cause an error
                    var res = SomethingCanGoWrong(100, 2);
                    Console.WriteLine($"Result: {res}");
                    break;
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message} - Why cant you listen!!");
            //throw;
            Console.WriteLine("But you will get another chance!");
        }
    }

    private static decimal SomethingCanGoWrong(decimal a, decimal b)
    {
        //throw new Exception("KaBoom!!");

        var res = a / b;
        return res;        
    }
}

