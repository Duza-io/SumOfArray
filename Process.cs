using System;


namespace SumOfArray
{
    class Process
    {
        private readonly int[] array;
        private readonly int index;
        private int element;

        //constructor
        public Process(int size)
        {
            array = new int[size];
            index = size - 1;
            element = 0;
        }

        public void Insert(ref int item)
        {
            array[element] = item;
            element++;
        }

        public void PrintElements()
        {
            for (int i = 0; i <= index; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public void PrintSortingProcess()
        {
            for (int i = 0; i <= index; i++)
            {
                Console.Write(array[i] + " ");
            }
            //friendly space
            Console.WriteLine();
        }

        public void SortElements()
        {
            int temp;
            for (int outt = index; outt >= 1; outt--)
            {
                for (int inn = 0; inn <= outt - 1; inn++)
                {
                    if (array[inn] > array[inn + 1])
                    {
                        temp = array[inn];
                        array[inn] = array[inn + 1];
                        array[inn + 1] = temp;
                    }
                }
                PrintSortingProcess();
            }
        }
    }
}
