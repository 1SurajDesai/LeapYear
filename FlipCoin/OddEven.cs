using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    public static class OddEven
    {
        public static void OddEvenNo()
        {
            string num;
            int newNum;
            Console.WriteLine("Enter a number to check");
            num = Console.ReadLine();
            newNum = Convert.ToInt32(num);
            if (newNum < 0)
            {
                Console.WriteLine("Enter a positive number");

            }
            else
            {
                if (newNum % 2 == 0)
                {
                    Console.WriteLine("Number is even");

                }
                else
                { 
                    Console.WriteLine("Number is odd");
                }

            }
            
        }
    }
}
