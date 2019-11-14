using StaticObj;
using System;
using static StaticObj.CommonObj;

namespace ElectronicAdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter charger = new Adapter();
            charger.GetAdaptee(PhoneCableType.MicroUSBCable.GetEnumDescription());
            charger.Charge();
        }
       

    }
}
