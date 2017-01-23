using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Test();
        }


        public static void MergeSort(int[] input, int start, int end)
        {
            if(start < end)
            {
                int middle = (start + end)/2;
                MergeSort(input, start, middle);
                MergeSort(input, middle+1, end);
                Merge(input, start, middle, end);
            }
        }

        public static void Merge(int[] input, int start, int middle, int end)
        {
            if(input ==null && input.Length <=1)
            {
                return;
            }
            int leftLength = middle - start + 2;
            int rightLength = end - middle  + 1;
            int[] left = new int[leftLength];
            int[] right = new int[rightLength];
            for(int i = start; i<= middle; i++)
            {
                left[i-start] = input[i];
            }

            left[leftLength-1] = int.MaxValue;
            for(int j= middle+1; j<= end; j++)
            {
                right[j-middle-1] = input[j];
            }
            right[rightLength-1] = int.MaxValue;
            int inputIndex = start;
            int leftIndex = 0;
            int rightIndex = 0;
            while(inputIndex <=end)
            {
                if(left[leftIndex]< right[rightIndex])
                {
                    input[inputIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    input[inputIndex] = right[rightIndex];
                    rightIndex++;
                }
                inputIndex++;
            }
        }

        public static void Test()
        {
            int[] input1 = {2,5,3};
            MergeSort(input1, 0, 2);
            Console.WriteLine(string.Join(", ", input1));
            int[] input2 = {6,4,2,1,0,-1};
            MergeSort(input2, 0,input2.Length-1);
            Console.WriteLine(string.Join(", ", input2));
            int[] input4 = {1,1,1,1,1};
            MergeSort(input4, 0 ,input4.Length-1);
            Console.WriteLine(string.Join(", ", input4));
            int[] input3 = {1};
            MergeSort(input3, 0,input3.Length-1);
            Console.WriteLine(string.Join(", ", input3));
            int[] input5 = {1,2,6,3,4,5};
            MergeSort(input5, 0,input5.Length-1);
            Console.WriteLine(string.Join(", ", input5));

        }
    }
}
