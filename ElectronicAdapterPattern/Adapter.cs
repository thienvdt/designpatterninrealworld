using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicAdapterPattern
{
    public class Adapter: Charger 
    {
        Iphone _ip = new Iphone();
        public override void Charge()
        {
            base.Charge();
            _ip.ReCharge();
        }
    }
}
