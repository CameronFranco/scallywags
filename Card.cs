namespace scallywags
{
    public class Card
    {
        private string title = "Card1";
        private string desc = "This is a card";
        private int cardPower;
        private string cardType;

        public Card(string Title, string Description, int CardPower, string CardType)
        {
            title = Title;
            desc = Description;
            cardPower = CardPower;
            cardType = CardType;
        }

        public string Title()
        {
            return title;
        }

        public string Description()
        {
            return desc;
        }
    }
}