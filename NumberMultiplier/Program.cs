using System;
using System.Collections.Generic;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            /* final output needs to be assigned an int when declared.
             * Since it is multiplied, we initialize it with a value of one to
             * not affect the multiplication
             */
            int finalMultiplicationOutput = 1;
            var MyTrueNums = new List<int>();
            string MyNumberList = "2,4,6";
            string finalPowerOutput = "";

            // split string on comma. convert to string array
            string[] sepNums = MyNumberList.Split(",");

            // loop over array and convert string to int
            foreach (string strNum in sepNums)
            {
                var x = int.Parse(strNum);

                // add individual numbers to MyTrueNums List
                MyTrueNums.Add(x);
            }


            Console.WriteLine($"You are working with the values {MyNumberList}");
            Console.WriteLine("You can");
            Console.WriteLine("(1.)   Multiply all the numbers together");
            Console.WriteLine("(2.)   Square each number individually");
            Console.WriteLine("Please enter the number you choose");
            string userChoice = Console.ReadLine();

            switch (userChoice) {

                // ---------------- Multiplication ----------------

                case "1":

                    // take each number in MyTrueNums List and multiply them together
                    foreach (int individualNum in MyTrueNums)
                    {
                        finalMultiplicationOutput *= individualNum;
                    }

                    // display the numbers multiplied together
                    Console.WriteLine(finalMultiplicationOutput);
                    break;

                // ---------------- to the power of ---------------

                case "2":

                    // loops over integer list
                    for (int i = 0; i < MyTrueNums.Count; i++)
                    {
                        // multiplies individual int by itself and adds it to final output string
                        finalPowerOutput += Convert.ToString(MyTrueNums[i] * MyTrueNums[i]);

                        // as long as item in loop isn't the final item, add a comma and space
                        if (i != (MyTrueNums.Count - 1))
                        {
                            finalPowerOutput += ", ";
                        }
                    }

                    Console.WriteLine(finalPowerOutput);
                    break;

                default:
                    break;
                }

            // -------------- Exit application ----------------
            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
        }
    }
}
