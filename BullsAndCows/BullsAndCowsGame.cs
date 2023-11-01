using System;

namespace BullsAndCows
{
    public class BullsAndCowsGame
    {
        private readonly SecretGenerator secretGenerator;
        private readonly string secret;
        public BullsAndCowsGame(SecretGenerator secretGenerator)
        {
            this.secretGenerator = secretGenerator;
            this.secret = secretGenerator.GenerateSecret();
        }

        public bool CanContinue => true;

        public string Guess(string guessString)
        {
            int cows = 0;

            if (guessString.Equals(secret))
            {
                return "4A0B";
            }

            for (int i = 0; i < guessString.Length; i++)
            {
                if (guessString[i].Equals(secret[i]))
                {
                    cows++;
                }
            }

            return $"{cows}A0B";
        }
    }
}