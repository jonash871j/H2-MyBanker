namespace MyBanker.Cards
{
    public class VISAElectron : ExpirationCard
    {
        private static string[] prefixNumbers = new string[]
        {
            "4026", "417500", "4508", "4844", "4913", "4917"
        };

        public VISAElectron(string holderName, int expirationYear, int expirationMonth)
            : base("VISAElectron", holderName, prefixNumbers, 16, expirationYear, expirationMonth)
        {
        }
    }
}
