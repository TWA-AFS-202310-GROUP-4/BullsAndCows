using System;

namespace BullsAndCows
{
    public class BullsAndCowsGame
    {
        private readonly SecretGenerator secretGenerator;
        private readonly string secrete;

        public BullsAndCowsGame(SecretGenerator secretGenerator)
        {
            this.secretGenerator = secretGenerator;
            secrete = secretGenerator.GenerateSecret();
        }

        public bool CanContinue => true;

        public string Guess(string guess)
        {
            int bulls = 0;
            if (guess.Equals(secrete))
            {
                return "4A0B";
            }

            for (int i = 0; i < secrete.Length; i++)
            {
                if (guess[i] == secrete[i])
                {
                    bulls++;
                }
            }

            return $"{bulls}A0B";
        }
    }
}