namespace PrototypePattern
{
    abstract class CardPrototype
    {
        public abstract CardPrototype Clone();
    }


    public class Card : CardPrototype
    {
        public int CardNumber { get; set; }
        public string CardName { get; set; }
        public Card(int cardNumber, string cardName)
        {
            this.CardName = CardName;
            this.CardNumber = CardNumber;
        }

        public override Clone()
        {
            global::System.Console.WriteLine("Clonning Card...");
            return new Card
            {
                CardName = CardName,
                CardNumber = CardNumber
            };
        }

        public class CardManager
        {
            private Dictionary<int, CardPrototype> _cards = new Dictionary<int, CardPrototype>();            
        }
    }
}
