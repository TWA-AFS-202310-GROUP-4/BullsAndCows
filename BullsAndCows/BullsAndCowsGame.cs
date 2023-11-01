using System;

namespace BullsAndCows
{
    public class BullsAndCowsGame
    {
        private readonly SecretGenerator secretGenerator;
        public BullsAndCowsGame(SecretGenerator secretGenerator)
        {
            this.secretGenerator = secretGenerator;
        }

        public bool CanContinue => true;

        public string Guess(string guess)
        {
            string secret = secretGenerator.GenerateSecret();
            if (secret.Equals(guess))
            {
                return "4A0B";
            }

            return string.Empty;
        }
    }
}