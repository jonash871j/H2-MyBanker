using System;

namespace MyBanker.Cards
{
    public abstract class ExpirationCard : Card
    {
        public int ExpirationYear { get; private set; }
        public int ExpirationMonth { get; private set; }

        public ExpirationCard(
            string cardName,
            string holderName,
            string[] prefixNumbers,
            int cardNumberLength,
            int expirationYear,
            int expirationMonth
        )
            : base(cardName, holderName, prefixNumbers, cardNumberLength)
        {
            ExpirationYear = expirationYear;
            ExpirationMonth = expirationMonth;

            // Checks if experation date is less than 5 years from now
            if (DateTime.Compare(new DateTime(ExpirationYear, ExpirationMonth, 1), DateTime.Now.AddYears(5)) > 0)
            {
                throw new Exception("Experation date must be less that 5 years!");
            }
        }

        public override string ToString()
        {
            return $"{CardName} owned by {HolderName}\n" +
             $"AccountNumber  : {AccountNumber}\n" +
             $"CardNumber     : {CardNumber}\n" +
             $"ExpirationDate : {ExpirationMonth}/{ExpirationYear}";
        }
    }
}
