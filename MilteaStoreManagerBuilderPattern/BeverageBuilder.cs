using StaticObj;

namespace MilkTeaStoreManagerBuilderPattern
{
   public abstract class BeverageBuilder
    {
        protected Beverage beverage;
        public Beverage Beverage { get {return beverage; } }

        public abstract void AddSugar();
        public abstract void AddMilk();
        public abstract void AddCoffee();
        public abstract void AddWater();
        public abstract void AddPearl();
        public abstract void AddTea();
        public abstract Beverage GetResult();
    }
    class MilkTeaBuilder : BeverageBuilder
    {
        public MilkTeaBuilder()
        {
            beverage = new Beverage("Milk Tea");
        }
        public override void AddCoffee()
        {
            beverage[CommonObj.MilkTeaIngedients.Coffee.GetEnumDescription()] = "0";
        }

        public override void AddMilk()
        {
            beverage[CommonObj.MilkTeaIngedients.Milk.GetEnumDescription()] = "100";
        }

        public override void AddPearl()
        {
            beverage[CommonObj.MilkTeaIngedients.Pearl.GetEnumDescription()] = "20";
        }

        public override void AddSugar()
        {
            beverage[CommonObj.MilkTeaIngedients.Sugar.GetEnumDescription()] = "0";
        }

        public override void AddTea()
        {
            beverage[CommonObj.MilkTeaIngedients.Tea.GetEnumDescription()] = "10";
        }

        public override void AddWater()
        {
            beverage[CommonObj.MilkTeaIngedients.Water.GetEnumDescription()] = "10";
        }

        public override Beverage GetResult()
        {
            return beverage;
         }
    }
    class CoffeeSaiGon : BeverageBuilder
    {
        public CoffeeSaiGon()
        {
            beverage = new Beverage("Coffee Sai Gon");
        }
        public override void AddCoffee()
        {
            beverage[CommonObj.MilkTeaIngedients.Coffee.GetEnumDescription()] = "100";
        }

        public override void AddMilk()
        {
            beverage[CommonObj.MilkTeaIngedients.Milk.GetEnumDescription()] = "0";
        }

        public override void AddPearl()
        {
            beverage[CommonObj.MilkTeaIngedients.Pearl.GetEnumDescription()] = "0";
        }

        public override void AddSugar()
        {
            beverage[CommonObj.MilkTeaIngedients.Sugar.GetEnumDescription()] = "10";
        }

        public override void AddTea()
        {
            beverage[CommonObj.MilkTeaIngedients.Tea.GetEnumDescription()] = "0";
        }

        public override void AddWater()
        {
            beverage[CommonObj.MilkTeaIngedients.Water.GetEnumDescription()] = "10";
        }

        public override Beverage GetResult()
        {
            return beverage;
        }
    }
}
