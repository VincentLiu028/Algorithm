using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            test();
        }

        public static int[] sumBinary(int[] first, int[] second)
        {
            var inputlength = first.Length >= second.Length? first.Length : second.Length;
            int[] result = new int[inputlength+1];
            int i = first.Length-1;
            int j = second.Length-1;
            int outputIndex = inputlength-1;            
            int extra = 0;
            while(i>=0 || j>=0)
            {
                int firstNum =  i>=0 ? first[i] :0;
                int secondNum = j>=0 ? second[j] :0;
                int resultNum = firstNum ^ secondNum ^ extra;
                result[outputIndex] = resultNum;
                if(firstNum + secondNum +　extra >2)
                {
                    extra = 1;
                }

                else
                {
                    extra = 0;
                }

                i--;
                j--;
                outputIndex--;
            }
            result[0]=extra;
            return result;
        }

        public static void test()
        {
            int[] first = {0,1,1,1,1,0};
            int[] second = {0,1,0};
            Console.WriteLine(String.Join( ", ",sumBinary(first, second)));
            int[] first1= {0,1,1,0,1,1,1,0};
            int[] second1 = {1,1,1,1,1,1,1,1,1,1};
            Console.WriteLine(String.Join( ", ",sumBinary(first1, second1)));
            int[] first2 = {0,0,0};
            int[] second2 = {1,1,1};
            Console.WriteLine(String.Join( ", ",sumBinary(first2, second2)));
            int[] first3 = {1,1,1,1,1,1};
            int[] second3 = {1,1,1,1,1};
            Console.WriteLine(String.Join( ", ",sumBinary(first3, second3)));
            int[] first4 = {0,0,0};
            int[] second4 = {0,0,0,0};
            Console.WriteLine(String.Join( ", ",sumBinary(first4, second4)));
        }
    }
}
