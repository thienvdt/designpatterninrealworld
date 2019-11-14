using System;
using System.Collections.Generic;

namespace CompanyDiectoryCompositDesignPattern
{
    public class Department : Component 
    {
        List<Component> _childObj = new List<Component>();
        private string _name;
        public Department(string name) : base(name)
        {
            this._name = name;
        }

        public override Component Add(Component c)
        {
            _childObj.Add(c);
            return c;
        }

        public override void Display(int detph)
        {
            Console.WriteLine(new String('-', detph) + _name);

            foreach (var component in _childObj)
            {
                component.Display(detph+2);
            }
        }

        public override bool Remove(Component c)
        {
            _childObj.Remove(c);
            return true;
        }
    }
}
