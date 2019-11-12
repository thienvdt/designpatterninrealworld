using System;

namespace MilkTeaStoreManagerBuilderPattern
{
    public class Program
    {
     public static void Main(string[] args)
        {
            BeverageBuilder builder;
            Store store = new Store();


            builder = new MilkTeaBuilder();
            store.MakeBeverage(builder);
            builder.Beverage.ShowBeverage();


            builder = new CoffeeSaiGon();
            store.MakeBeverage(builder);
            builder.Beverage.ShowBeverage();
    
        }

    }
}
