using MyBanker.Misc;
using System;

namespace MyBanker.Cards
{
    public abstract class Card
    {
        private Random randomGenerator = new Random();

        private const string REG_NUMBER = "3520";
        private const int ACOUNT_NUMBER_LENGTH = 14;

        protected string[] PrefixNumbers { get; private set; }
        protected int CardNumberLength { get; private set; }

        public string CardName { get; private set; }
        public string HolderName { get; set; }
        public string AccountNumber { get; private set; }
        public string CardNumber { get; private set; }

        public Card(string cardName, string holderName, string[] prefixNumbers, int cardNumberLength)
        {
            CardName = cardName;
            HolderName = holderName;
            AccountNumber = GenerateAccountNumber();
            PrefixNumbers = prefixNumbers;
            CardNumberLength = cardNumberLength;
            CardNumber = GenerateCardNumber();
        }

        public override string ToString()
        {
            return $"{CardName} owned by {HolderName}\n" +
                $"AccountNumber  : {AccountNumber}\n" +
                $"CardNumber     : {CardNumber}";
        }

        /// <summary>
        /// Used to genereates account number.
        /// The first numbers are the RegNumber and the rest are random
        /// </summary>
        private string GenerateAccountNumber()
        {
            string randomNumber = StringGenerator.GetRandomStringNumber(ACOUNT_NUMBER_LENGTH - REG_NUMBER.Length);

            return $"{REG_NUMBER}{randomNumber}";
        }
        /// <summary>
        /// Used to genereates card number.
        /// The first numbers are one of the prefix numbers and the rest are random
        /// </summary>
        private string GenerateCardNumber()
        {
            int prefixIndex = randomGenerator.Next(0, PrefixNumbers.Length);
            string randomPrefix = PrefixNumbers[prefixIndex];
            string randomNumber = StringGenerator.GetRandomStringNumber(CardNumberLength - randomPrefix.Length);

            return $"{randomPrefix}{randomNumber}";
        }
    }
}
