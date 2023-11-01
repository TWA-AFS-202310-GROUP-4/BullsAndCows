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
            int cows = 0;
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

            for (int i = 0; i < secrete.Length; i++)
            {
                if (guess.IndexOf(secrete[i]) >= 0 && guess.IndexOf(secrete[i]) != i)
                {
                    cows++;
                }
            }

            return $"{bulls}A{cows}B";
        }
    }
}