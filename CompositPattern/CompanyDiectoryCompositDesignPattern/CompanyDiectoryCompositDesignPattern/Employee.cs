using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyDiectoryCompositDesignPattern
{
    class Employee : Component
    {
        private string _name;

        public Employee(string name): base(name)
        {
            this._name = name;
        }

        public override Component Add(Component c)
        {
            Console.WriteLine("You cannot add anythings to employee");
            return null;
        }

        public override void Display(int detph)
        {
            Console.WriteLine(new String('-', detph)+_name);
        }

        public override bool Remove(Component c)
        {
            Console.WriteLine("You cannot remove anythings from employee");
            return false;
        }
    }
}
