using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicAdapterPattern
{
    class IphoneAdaptee: PhoneAdaptee
    {
        public Random rd = new Random();
        private bool isIPhoneAdapterConnected = false;

        public override void ReCharge()
        {
            int percentToCompletedCharge = 0;
            Console.WriteLine("======================***==================");
            Console.WriteLine($"Iphone phone is charging...");
            while (percentToCompletedCharge < 100)
            {
                percentToCompletedCharge = percentToCompletedCharge < 100 ? percentToCompletedCharge +=10 : 100;
                Console.WriteLine($"Recharge {percentToCompletedCharge} %");
            }
            _ = percentToCompletedCharge < 100 ? percentToCompletedCharge : 100;
            Console.WriteLine($"Fully charging!");
        }
        public IphoneAdaptee()
        {
            RegisterLightningPort();
        }
        public void RegisterLightningPort()
        {
            isIPhoneAdapterConnected = true;
            Console.WriteLine("Lightning port has register successfully and ready to use");
        }

    }
}
