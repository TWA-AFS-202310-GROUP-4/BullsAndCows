using System;

namespace BullsAndCows
{
    public class SecretGenerator
    {
        public virtual string GenerateSecret()
        {
            var random = new Random();
            var number = string.Empty;
            while (number.Length < 4)
            {
                var digit = random.Next(10);
                if (!number.Contains(digit.ToString()) && !(number == string.Empty && digit == 0))
                {
                    number += digit;
                }
            }

            return number;
        }
    }
}