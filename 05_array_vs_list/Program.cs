using System;

namespace _05_array_vs_list // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("05_array_vs_list");


            int[] my_int_array = new int[10];
            List<int> my_int_list = new List<int>();

            for (int i = 0; i < my_int_array.Length; i++)
            {
                my_int_array[i] = i * 100;
            }
            for (int i = 0; i < my_int_array.Length; i++)
            {
                Console.Write($"{my_int_array[i]}, ");
            }

            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                my_int_list.Add(i * 100);
            }

            for (int i = 0; i < my_int_list.Count; i++)
            {
                Console.Write($"{my_int_list[i]}, ");
            }
        }
    }
}
