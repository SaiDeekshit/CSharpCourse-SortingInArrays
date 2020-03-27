using System;

namespace SortingInArrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 2, 1, 4, 3 };
            String[] numberNames = { "two", "one", "four", "three" };

            Array.Sort(numbers, numberNames);

            Array.ForEach<int>(numbers, n => Console.WriteLine(n));//[1,2,3,4]
            Array.ForEach<string>(numberNames, s => Console.WriteLine(s));//["one", "two", "three", "four"]
        }
    }
}
