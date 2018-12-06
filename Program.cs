using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> boxedData = new List<object>();
            boxedData.Add(7);
            boxedData.Add(28);
            boxedData.Add(-1);
            boxedData.Add(true);
            boxedData.Add("chair");
            for (var i = 0; i < boxedData.Count; i++)
            {
                Console.WriteLine(boxedData[i]);
            }
            int val1 = Convert.ToInt32(boxedData[0]);
            int val2 = Convert.ToInt32(boxedData[1]);
            int val3 = Convert.ToInt32(boxedData[2]);
            int sum = val1 + val2 + val3;
            Console.WriteLine(sum);
        }
    }
}
