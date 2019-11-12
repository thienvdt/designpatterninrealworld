using System;

namespace BankCardPrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CardManager card = new CardManager();
            card["CashBack"] = new Card("Cash back money when paying goods", "CreaditCard");
            card["ATM"] = new Card("Withdrwal money at ATM", "ATM");
            card["Credit"] = new Card("Credit money to card", "Credit");
            card["Debit"] = new Card("Pay money first", "Debit");

            Customer cs = new Customer(1, "Alex Vo");

            //Assign credit card to customer Alex
            cs.CustomerCards.Add(card["CashBack"].Clone() as Card);
            cs.CustomerCards.Add(card["ATM"].Clone() as Card);
            cs.CustomerCards.Add(card["Credit"].Clone() as Card);
            cs.CustomerCards.Add(card["Debit"].Clone() as Card);


            //Assign credit card to customer John Doe

            Customer cs1 = new Customer(1, "John Doe");
            cs1.CustomerCards.Add(card["CashBack"].Clone() as Card);
            cs1.CustomerCards.Add(card["ATM"].Clone() as Card);


            Console.WriteLine($"Card informartion of customer {cs.CustomerName}");
            for (int i = 0; i < cs.CustomerCards.Count; i++)
            { 
                Console.WriteLine("=================***====================");
                Console.WriteLine($"Card {i}: {cs.CustomerCards[i].CardType}| purpose: {cs.CustomerCards[i].CardPurpose}");
            }

            Console.WriteLine($"\n Card informartion of customer {cs1.CustomerName}");

            for (int i = 0; i < cs1.CustomerCards.Count; i++)
            {
                Console.WriteLine("=================***====================");
                Console.WriteLine($"Card {i}: {cs.CustomerCards[i].CardType}| purpose: {cs.CustomerCards[i].CardPurpose}");
            }
            //todo: save to db context
            Console.WriteLine("Done");
        }
    }
}
