using System;

namespace AIE_01_GetTwoLenghts
{
    class Program
    {
        static int [] GetTwoLengths(string str1, string str2)
        {
            int[] lenghts = new int[2];
            lenghts [0] = str1.Length;
            lenghts [1] = str2.Length;
            return lenghts;

        }




        static void Main(string[] args)
        {
            var strLengths1 = GetTwoLengths("hello", "world");
            var strLengths2 = GetTwoLengths("", "hello world");
            var strLengths3 = GetTwoLengths("aaaa", "bbbbbbbbbbbbbbb");

            Console.WriteLine(strLengths1[0]); // 5
            Console.WriteLine(strLengths1[1]); // 5

            Console.WriteLine(strLengths2[0]); // 0
            Console.WriteLine(strLengths2[1]); // 11

            Console.WriteLine(strLengths3[0]); // 4
            Console.WriteLine(strLengths3[1]); // 15
        }
    }
}
