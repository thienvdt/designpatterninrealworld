using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicAdapterPattern
{
    class SamsungGalaxyNote
    {
        public Random rd = new Random();
        public void ReCharge()
        {
            int percentToCompletedCharge = 0;
            Console.WriteLine("======================***==================");
            Console.WriteLine($"Samsung phone is charging...");
            for (int i = 0; i < 10; i++)
            {
                _= percentToCompletedCharge < 0 ?percentToCompletedCharge += rd.Next(percentToCompletedCharge, 100) : percentToCompletedCharge;
                Console.WriteLine($"Recharge {percentToCompletedCharge} %");
            }

        }

        public void UseMicroUSB()
        {
            Console.WriteLine("Connected to Micro USB charger");
        }
    }
}
