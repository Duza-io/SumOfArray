using System;


namespace SumOfArray
{
    class BasicMath
    {
        public static void Add(ref int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                temp += array[i];
            }
            Console.WriteLine("\nSum: {0}", temp);
        }
        public static void Average(ref int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                temp += array[i];
            }

            double ave = (float) temp / array.Length;

            Console.WriteLine("\nAverage: {0}", ave);
        }
    }
}
