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
            //if (secret.Equals(guess))
            //{
            //    return "4A0B";
            //}

            int bulls = 0;
            int cows = 0;
            for (int i = 0; i < secret.Length; i++)
            {
                if (secret[i] == guess[i])
                {
                    bulls++;
                }
            }

            for (int i = 0; i < secret.Length; i++)
            {
                if (secret.IndexOf(guess[i]) >= 0 && secret.IndexOf(guess[i]) != i)
                {
                    cows++;
                }
            }

            return $"{bulls}A{cows}B";
        }
    }
}