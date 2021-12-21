using System;

namespace SumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;

            int[] storage = new int[10]; //storage for random numbers

            Random random = new(); // Random class that will choose ten numbers between 1-100 and store it in array

            for (int i = 0; i < storage.Length; i++)
            {
                storage[i] = random.Next(min, max);
            }

            //i'll copy here all the elements from the first array (storage)
            int[] mainArray = new int[storage.Length];

            for (int a = 0; a < storage.Length; a++)
            {
                mainArray[a] = storage[a];
            }

            /*
            time to sort the random elements in mainArray
            from lowest to highest
            */

            Process sort = new(mainArray.Length);

            for (int i = 0; i < mainArray.Length; i++)
            {
                sort.Insert(ref mainArray[i]);
            }

            Console.WriteLine("\tSorting the elements\n");

            Console.Write("Random elements in my array: ");
            sort.PrintElements();

            Console.Write("\n\nBefore: ");
            sort.PrintElements();

            Console.WriteLine("\n\nDuring: ");
            sort.SortElements();

            Console.Write("\n\nAfter: ");
            sort.PrintElements();

            Console.WriteLine("\n\n\tNow it's time to perform basic math!");
            //static methods can be called directly from the class file, it doesn't need an object
            BasicMath.Add(ref mainArray);
            BasicMath.Average(ref mainArray);

            Console.ReadKey(true);
        }
    }
}
