namespace MyBanker.Cards
{
    public class Maestro : ExpirationCard
    {
        private static string[] prefixNumbers = new string[]
        {
            "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763",
        };

        public Maestro(string holderName, int expirationYear, int expirationMonth)
            : base("Maestro", holderName, prefixNumbers, 19, expirationYear, expirationMonth)
        {
        }
    }
}
