using System;

namespace CSharp_Class_4_Debugging_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var example = new[] {1, 2, 3, 4, 5};

            var averages = CalculateNeighbourAverages(example);

            foreach (var average in averages)
            {
                Console.WriteLine(average);
            }

            Console.ReadKey();
        }

        static int[] CalculateNeighbourAverages(int[] array)
        {
            var averages = new int[array.Length / 2];

            var count = 1;

            for (int i = 0; i < array.Length; i++)
            {
                averages[count] = array[i] + array[i + 1] / 2;
            }

            return averages;
        }
    }
}
