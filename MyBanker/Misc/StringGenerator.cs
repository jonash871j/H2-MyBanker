using System;

namespace MyBanker.Misc
{
    public static class StringGenerator
    {
        private static Random randomGenerator = new Random();

        /// <summary>
        /// Used to generate random string number
        /// </summary>
        public static string GetRandomStringNumber(int length)
        {
            string stringNumber = "";
            
            for (int i = 0; i < length; i++)
            {
                stringNumber += randomGenerator.Next(0, 9);
            }

            return stringNumber;
        }
    }
}
