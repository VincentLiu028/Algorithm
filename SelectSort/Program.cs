using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            test();
        }

        public static int[] selectSort(int[] input)
        {
            if (input == null || input.Length == 0)
            {
                return input;
            }

            int minValueIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    if (input[j] < input[minValueIndex])
                    {
                        minValueIndex = j;
                    }
                }

                if (i != minValueIndex)
                {
                    var temp = input[i];
                    input[i] = input[minValueIndex];
                    input[minValueIndex] = temp;
                }
                minValueIndex = i + 1;
            }

            return input;
        }

        public static void test()
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 8 };
            Console.WriteLine(String.Join(", ", selectSort(input)));
            int[] input1 = { 5, -1, 4, 3, -5, 11, 5 };
            Console.WriteLine(String.Join(", ", selectSort(input1)));
            int[] input2 = { 9, 4, 2, 1, -5 };
            Console.WriteLine(String.Join(", ", selectSort(input2)));
            int[] input3 = { -1, -1, -1, -1 };
            Console.WriteLine(String.Join(", ", selectSort(input3)));
        }
    }
}
