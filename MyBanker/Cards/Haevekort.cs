namespace MyBanker.Cards
{
    public class Haevekort : Card
    {
        private static string[] prefixNumbers = new string[]
        {
            "2400",
        };

        public Haevekort(string holderName) 
            : base("Haevekort", holderName, prefixNumbers, 16)
        {
        }
    }
}
