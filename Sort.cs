using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 5, 2, 1, 4 };
            Array.Sort(arr);
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
