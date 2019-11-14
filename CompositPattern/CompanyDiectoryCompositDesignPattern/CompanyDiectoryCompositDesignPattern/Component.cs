namespace CompanyDiectoryCompositDesignPattern
{
    public abstract class Component
    {
        private string _name { get; set; }
        public Component(string name)
        {
            this._name = name;
        }

        //Operations

        public abstract Component Add(Component c);
        public abstract  bool Remove(Component c);
        public abstract void Display(int detph);
    }
}
