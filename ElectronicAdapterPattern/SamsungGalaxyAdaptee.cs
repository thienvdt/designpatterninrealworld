using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicAdapterPattern
{
    class SamsungGalaxyAdaptee : PhoneAdaptee
    {
        public Random rd = new Random();
        private bool isSamsungPhoneConnected = false;
        public override void ReCharge()
        {
            int percentToCompletedCharge = 0;
            Console.WriteLine("======================***==================");
            Console.WriteLine($"Samsung phone is charging...");
            for (int i = 0; i < 10; i++)
            {
                percentToCompletedCharge = percentToCompletedCharge < 100 ? percentToCompletedCharge += 10 : 100;
                Console.WriteLine($"Charging {percentToCompletedCharge} %");
            }
            _ = percentToCompletedCharge < 100 ? percentToCompletedCharge : 100;
            Console.WriteLine($"Fully charging!");
        }
        public SamsungGalaxyAdaptee()
        {
            RegisterMicroUSB();
        }
        public void RegisterMicroUSB()
        {
            isSamsungPhoneConnected = true;
            Console.WriteLine("MicroUSB has register successfully and ready to use");
        }
    }
}
