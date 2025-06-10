using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Solution3 solution3 = new Solution3();
        int[] array1 = new int[] { -1, 0, 3, 0, 0, 0 };
        solution3.Merge(array1, 3, new int[] { -1, 9 }, 2);

        StringBuilder outputConent = new StringBuilder();
        for (int i = 0; i < array1.Length; i++)
        {
            outputConent.Append(array1[i]).Append(",");
        }
        Console.WriteLine(outputConent.ToString());

        Console.WriteLine("Hello, World!");
    }
}