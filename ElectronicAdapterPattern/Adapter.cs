using StaticObj;
using System.Collections.Generic;
using static StaticObj.CommonObj;

namespace ElectronicAdapterPattern
{
    public class Adapter : Charger
    {
        Dictionary<string, PhoneAdaptee> _adapter = new Dictionary<string, PhoneAdaptee>();
        private PhoneAdaptee _adapteeInUsed;
        public Adapter()
        {
            _adapter.Add(PhoneCableType.Lightning.GetEnumDescription(), new IphoneAdaptee());
            _adapter.Add(PhoneCableType.MicroUSBCable.GetEnumDescription(), new SamsungGalaxyAdaptee());
            System.Console.WriteLine("Successfully register phone");
            System.Console.WriteLine("===========================================");
        }

        public override void Charge()
        {
            base.Charge();
            _adapteeInUsed.ReCharge();
        }
        public void GetAdaptee(string value)
        {
            _adapter.TryGetValue(value, out var returnAdaptee);
            _adapteeInUsed = returnAdaptee;
        }
    }
}
