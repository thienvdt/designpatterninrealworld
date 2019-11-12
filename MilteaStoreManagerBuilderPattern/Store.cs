namespace MilkTeaStoreManagerBuilderPattern
{
    public class Store
    {
        public void MakeBeverage(BeverageBuilder builder)
        {
            builder.AddCoffee();
            builder.AddMilk();
            builder.AddPearl();
            builder.AddSugar();
            builder.AddWater();
            builder.AddTea();
        } 
    }
}
