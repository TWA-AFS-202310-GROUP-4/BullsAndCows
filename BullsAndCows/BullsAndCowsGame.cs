using System;

namespace BullsAndCows
{
    public class BullsAndCowsGame
    {
        private readonly SecretGenerator secretGenerator;
        private readonly string secretNumber;
        private int attemp;

        public BullsAndCowsGame(SecretGenerator secretGenerator)
        {
            this.secretGenerator = secretGenerator;
            this.secretNumber = secretGenerator.GenerateSecret();
        }

        public bool CanContinue => attemp < 6;

        public string Guess(string guess)
        {
            var bulls = 0;
            var cows = 0;

            for (var i = 0; i < guess.Length; i++)
            {
                if (guess[i] == secretNumber[i])
                {
                    bulls++;
                }
                else if (secretNumber.Contains(guess[i]))
                {
                    cows++;
                }
            }

            attemp++;

            return $"{bulls}A{cows}B";
        }
    }
}