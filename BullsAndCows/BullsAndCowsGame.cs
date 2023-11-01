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

        public string Guess(string guess)
        {
            int x = 0, y = 0;
            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == this.secret[i])
                {
                    x++;
                }
                else if (this.secret.IndexOf(guess[i]) >= 0)
                {
                    y++;
                }
            }

            return $"{x}A{y}B";
        }
    }
}