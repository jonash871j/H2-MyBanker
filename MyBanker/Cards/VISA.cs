using System;
using System.Collections.Generic;
using System.Text;
namespace MyBanker.Cards
{
    public class VISA : ExpirationCard
    {
        private static string[] prefixNumbers = new string[]
        {
            "4",
        };

        public VISA(string holderName, int expirationYear, int expirationMonth)
            : base("VISA", holderName, prefixNumbers, 16, expirationYear, expirationMonth)
        {

        }
    }
}
