using System;
using System.Collections.Generic;
using System.Text;

namespace BankCardPrototypePattern
{
 public class Customer
    {

        public int Id { get; set; }
        public string CustomerName{ get; set; }
        public List<Card> CustomerCards = new List<Card>();
        public Customer(int id, string name)
        {
            this.Id = id;
            this.CustomerName = name;
        }
    }
}
