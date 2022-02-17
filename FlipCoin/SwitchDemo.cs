using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    public class SwitchDemo
    {
        public static void DispalyMonth()
        {
            Console.WriteLine("Display the month using random function");
            Random random = new Random();
            int num = random.Next(12);

            switch(num)
            { 
                case 0:
                    Console.WriteLine("Month is January");
                    break;
                case 1:
                    Console.WriteLine("Month is February");
                    break;
                case 2:
                    Console.WriteLine("Month is March");
                    break;
                case 3:
                    Console.WriteLine("Month is April");
                    break;
                case 4:
                    Console.WriteLine("Month is may");
                    break;
                case 5:
                    Console.WriteLine("Month is June");
                    break;
                case 6:
                    Console.WriteLine("Month is July");
                    break;
                case 7:
                    Console.WriteLine("Month is August");
                    break;
                case 8:
                    Console.WriteLine("Month is September");
                    break;
                case 9:
                    Console.WriteLine("Month is Octomber");
                    break;
                case 10:
                    Console.WriteLine("Month is November");
                    break;
                case 11:
                    Console.WriteLine("Month is December");
                    break;
                default:
                    Console.WriteLine("Month is invalid");
                    break;

            }
        }
    }
}
