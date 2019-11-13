using System;

namespace ElectronicAdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Charger charger = new Adapter();

            charger.Charge();
        }
       

    }
}
