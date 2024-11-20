namespace _11a_error_handling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("11a_error_handling");
        /*
        DateTime[] myDates = new DateTime[100];
        var rnd = new Random();

        int datesWritten = 0;
        for (int i = 0; i < myDates.Length; i++)
        {
            string aRandomDate = $"{rnd.Next(2000, 2021)}-{rnd.Next(1, 13)}-{rnd.Next(1, 32)}";

            // below will crash on invalid dates
            myDates[i] = DateTime.Parse(aRandomDate);

            Console.WriteLine(myDates[i]);
            datesWritten++;


        }
        Console.WriteLine(datesWritten);
        */

        Console.WriteLine($"\nDifferent error handling solutions");
        /*
        #region Using for-loop with i--
        
        DateTime[] myDates = new DateTime[100];
        var rnd = new Random();

        Console.WriteLine("\nUsing for-loop with i--");
        int datesWritten = 0;
        for (int i = 0; i < myDates.Length; i++)
        {
            try
            {
                string aRandomDate = $"{rnd.Next(2000, 2021)}-{rnd.Next(1, 13)}-{rnd.Next(1, 32)}";
                myDates[i] = DateTime.Parse(aRandomDate);
                Console.WriteLine($"{myDates[i]:d}");
                datesWritten++;
            }
            catch
            {
                i--;
            }
        }
        Console.WriteLine($"Dates written: {datesWritten}");
        
        #endregion
        */
        #region Using for-loop with try-catch

        DateTime[] myDates = new DateTime[100];
        var rnd = new Random();

        Console.WriteLine("\nUsing for-loop with try-catch");
        int datesWritten = 0;
        for (int i = 0; i < myDates.Length; i++)
        {
            bool ValidDate = false;
            DateTime Date = default;
            while (!ValidDate)
            {
                try
                {
                    string aRandomDate = $"{rnd.Next(2000, 2021)}-{rnd.Next(1, 13)}-{rnd.Next(1, 32)}";
                    Date = DateTime.Parse(aRandomDate);
                    ValidDate = true;
                }
                catch { }
            }
            myDates[i] = Date;
            Console.WriteLine($"{myDates[i]:d}");
            datesWritten++;
        }
        Console.WriteLine($"Dates written: {datesWritten}");
        
        #endregion
        #region Using for-loop with TryParse
        /*
        Console.WriteLine("\nUsing for-loop with TryParse");
        datesWritten = 0;
        for (int i = 0; i < myDates.Length; i++)
        {
            bool ValidDate = false;
            DateTime Date = default;
            while (!ValidDate)
            {
                string aRandomDate = $"{rnd.Next(2000, 2021)}-{rnd.Next(1, 13)}-{rnd.Next(1, 32)}";
                if (DateTime.TryParse(aRandomDate, out Date))
                    ValidDate = true;
            }
            myDates[i] = Date;
            Console.WriteLine($"{myDates[i]:d}");
            datesWritten++;
        }
        Console.WriteLine($"Dates written: {datesWritten}");
        */
        #endregion
        #region Using While-loop with TryParse
        /*
        Console.WriteLine("\nUsing while-loop with TryParse");
        int c = datesWritten = 0;
        while (c < myDates.Length)
        {
            string aRandomDate = $"{rnd.Next(2000, 2021)}-{rnd.Next(1, 13)}-{rnd.Next(1, 32)}";
            if (DateTime.TryParse(aRandomDate, out myDates[c]))
            {
                Console.WriteLine($"{myDates[c]:d}");
                c++;
                datesWritten++;
            }
        }
        Console.WriteLine($"Dates written: {datesWritten}");
        */
        #endregion
    }
}

