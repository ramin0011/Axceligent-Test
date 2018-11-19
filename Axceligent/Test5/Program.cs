using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    class Program
    {
        static void Main(string[] args)
        {
            CallMethod();
        }

        private static async void CallMethod()
        {
            var (averageSalary, numberOfEmployee) = await SomeCalculation(0L, 10L, 0L == 10L);
        }

        private static async Task<Tuple<int, int>> SomeCalculation(long l, long l1, bool b)
        {
          return new Tuple<int, int>(0,0);
        }
    }
}
