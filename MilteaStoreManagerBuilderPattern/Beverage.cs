using StaticObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTeaStoreManagerBuilderPattern
{
    public class Beverage
    {
        private string _beverageType;
        private Dictionary<string, string> _part = new Dictionary<string, string>();
        public Beverage(string beverageType)
        {
            _beverageType = beverageType;
        }
        public string this[string key]{ get { return _part[key]; } set { _part[key] = value; } }
        public void ShowBeverage()
        {
            Console.WriteLine($"====================={_beverageType} Ingredients====================");
            Console.WriteLine($"Sugars: {_part[CommonObj.MilkTeaIngedients.Sugar.GetEnumDescription()]}");
            Console.WriteLine($"Milk: {_part[CommonObj.MilkTeaIngedients.Milk.GetEnumDescription()]}");
            Console.WriteLine($"Coffee: {_part[CommonObj.MilkTeaIngedients.Coffee.GetEnumDescription()]}");
            Console.WriteLine($"Tea: {_part[CommonObj.MilkTeaIngedients.Tea.GetEnumDescription()]}");
            Console.WriteLine($"Perl: {_part[CommonObj.MilkTeaIngedients.Pearl.GetEnumDescription()]}");
            Console.WriteLine($"BlankWater: {CommonObj.MilkTeaIngedients.Water.GetEnumDescription()}");
        }
    }
}
