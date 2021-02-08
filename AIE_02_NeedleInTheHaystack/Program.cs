using System;

namespace AIE_02_NeedleInHaystack
{
    class Program
    {
        static int FindNeedle(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "needle")
                    return i;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            var strings = new string[]
            {"hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk" };
            // 0         1       2      3      4           5         6

            int needleLocation = FindNeedle(strings);
            if (needleLocation < 0)
            {
                Console.WriteLine("Did not find Needle");
            }
            else
            {
                Console.WriteLine("Found needle at location: " + needleLocation);
            }
        }
    }
}
