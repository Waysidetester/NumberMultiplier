using System;
using System.Collections.Generic;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            int finalOutput = 1;
            var MyTrueNums = new List<int>();
            string MyNumberList = "2,4,6";
            string[] sepNums = MyNumberList.Split(",");
            foreach (string strNum in sepNums)
            {
                var x = Int32.Parse(strNum);
                MyTrueNums.Add(x);
            }
            foreach (int individualNum in MyTrueNums)
            {
                finalOutput *= individualNum;
            }
            Console.WriteLine(finalOutput);
            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
        }
    }
}
