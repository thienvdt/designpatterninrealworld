using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicAdapterPattern
{
    class Iphone
    {
        public Random rd = new Random();
        public void ReCharge()
        {
            int percentToCompletedCharge = 0;
            Console.WriteLine("======================***==================");
            Console.WriteLine($"Iphone phone is charging...");
            while (percentToCompletedCharge < 100)
            {
                percentToCompletedCharge = percentToCompletedCharge < 100 ? percentToCompletedCharge +=10 : 100;
                Console.WriteLine($"Recharge {percentToCompletedCharge} %");
            }
            percentToCompletedCharge = percentToCompletedCharge < 100 ? percentToCompletedCharge : 100;
            Console.WriteLine("Full baterry");

        }
    }
}
