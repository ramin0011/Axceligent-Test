using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write some numbers separate each number with a comma eg: 1,2,3   //complexity : O(N^2)");
            int[] numbers = Console.ReadLine().Split(',').Select(a => Convert.ToInt32(a)).ToArray();
            var output = Challenge(numbers);
            Console.WriteLine($"Output : {output}");
            Console.ReadLine();
        }

        public static int Challenge(int[] input)
        {
            Dictionary<int, int> NumbersCounts = new Dictionary<int, int>();

            foreach (var i in input)
            {
                if (!NumbersCounts.ContainsKey(i))
                    NumbersCounts.Add(i, 1);
                else
                    NumbersCounts[i] = NumbersCounts[i] + 1;
            }

            var m = NumbersCounts.Max(a => a.Value);

            var finalNumbers = new List<int>();

            int result = 0;

            for (var index = 0; index < input.Length; index++)
            {
                var i = input[index];
                if (NumbersCounts[i] >= m-1)
                {
                    finalNumbers.Add(i);
                    if (finalNumbers.Count>1)
                    {
                        if (result < finalNumbers[finalNumbers.Count - 2] + finalNumbers[finalNumbers.Count -1])
                            result = finalNumbers[finalNumbers.Count - 2] + finalNumbers[finalNumbers.Count - 1];
                    }
                    else
                        result = i;
                }
            }

            return result;
        }
    }
}
