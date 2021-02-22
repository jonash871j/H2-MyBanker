namespace MyBanker.Cards
{
    public class Mastercard : ExpirationCard
    {
        private static string[] prefixNumbers = new string[]
        {
            "51", "52", "53", "54", "55",
        };

        public Mastercard(string holderName, int expirationYear, int expirationMonth)
            : base("Mastercard", holderName, prefixNumbers, 16, expirationYear, expirationMonth)
        {
        }
    }
}
