namespace BankCardPrototypePattern
{
    using System;
    using System.Collections.Generic;
    public abstract class CardPrototype
    {
        public abstract CardPrototype Clone();
    }
    public class Card : CardPrototype
    {
        public string CardPurpose { get; set; }
        public string CardType { get; set; }
        public Card(string cardPurpose, string cardType)
        {
            this.CardPurpose = cardPurpose;
            this.CardType = cardType;
        }

        public override CardPrototype Clone()
        {
            Console.WriteLine($"Clonning Card...{this.CardType}");
            return this.MemberwiseClone() as CardPrototype;
        }
    }
    public class CardManager
    {
        private Dictionary<string, CardPrototype> _cards = new Dictionary<string, CardPrototype>();
        public CardPrototype this[string key]
        {
            get { return _cards[key]; }
            set { _cards.Add(key, value); }

        }
    }
}
