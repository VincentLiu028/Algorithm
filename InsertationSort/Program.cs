using System;
using System.Text;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Test();
        }

        public static int[] InsertionSort(int[] input)
        {
            if(input.Length <= 1)
                return input;
            for(int j=1; j<input.Length; j++)
            {
                var key = input[j];
                var i = j-1;
                while(i>=0 && input[i]>key)
                {
                    input[i+1] = input[i];
                    i--;
                }
                input[i+1] = key;
            }
            return input;    
        }

        public static void ReadArray(int[] input)
        {
            if(input == null || input.Length ==0)
                return;
            StringBuilder sb = new StringBuilder();
            sb.Append("{");            
            foreach(var i in input)
            {
                sb.Append(i.ToString()+ " " + ",");
            }
            sb.Append("}");
            Console.WriteLine(sb.ToString());
        }

        public static void Test()
        {
            int[] input = {2,1,3,6};
            var result = InsertionSort(input);
            ReadArray(result);
            int[] input1 = {1,2};
            var result1 = InsertionSort(input1);
            ReadArray(result1);
            int[] input2 = {1,23,41,1,1,1};
            var result2 = InsertionSort(input2);
            ReadArray(result2);
            int[] input3 = {7,6,5,4,3,2,1};
            var result3 = InsertionSort(input3);
            ReadArray(result3);
        }
    }
}
