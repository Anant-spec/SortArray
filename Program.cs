using System;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 2, 5, 1, 4 };
            Console.WriteLine("Origina array:" + string.Join(",", numbers));
            BubbleSort(numbers);
            Console.WriteLine("Sorted array:" + string.Join(",", numbers));
            Console.ReadLine();
        }

        static void BubbleSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j <n-1-1; j++)
                {
                    if (numbers[j] > numbers[j+1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
        }
    }
}
