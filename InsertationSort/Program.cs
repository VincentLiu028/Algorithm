using System;
using System.Text;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Test("Increase");
            Test("Decrease");
        }

        public static int[] InsertionSort(int[] input, string sortSeq)
        {
            if(input.Length <= 1)
                return input;
            for(int j=1; j<input.Length; j++)
            {
                var key = input[j];
                var i = j-1;
                if(string.Compare(sortSeq.ToLower(), "increase")==0)
                {
                    while(i>=0 && input[i]>key)
                    {
                        input[i+1] = input[i];
                        i--;
                    }
                }

                else if(string.Compare(sortSeq.ToLower(), "decrease") ==0)
                {
                    while(i>=0 && input[i]<key)
                    {
                        input[i+1] = input[i];
                        i--;
                    }
                }

                else
                {
                    throw new Exception("invalid sequence parameters");
                }

                input[i+1] = key;
            }
            return input;    
        }

        public static void ReadArray(int[] input)
        {
            if(input == null || input.Length ==0)
                return;
            
            Console.WriteLine(String.Join(", ", input));
        }

        public static void Test(string sortSeq)
        {
            int[] input = {2,1,3,6};
            var result = InsertionSort(input, sortSeq);
            ReadArray(result);
            int[] input1 = {1,2};
            var result1 = InsertionSort(input1, sortSeq);
            ReadArray(result1);
            int[] input2 = {1,23,41,1,1,1};
            var result2 = InsertionSort(input2, sortSeq);
            ReadArray(result2);
            int[] input3 = {7,6,5,4,3,2,1};
            var result3 = InsertionSort(input3, sortSeq);
            ReadArray(result3);
            int[] input4 = {0,1,2,3,4,5,6};
            var result4 = InsertionSort(input4, sortSeq);
            ReadArray(result4);
        }
    }
}
