using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace BullsAndCows
{
    public class BullsAndCowsGame
    {
        private readonly SecretGenerator secretGenerator;
        private static int count = 0;
        public BullsAndCowsGame(SecretGenerator secretGenerator)
        {
            this.secretGenerator = secretGenerator;
        }

        public bool CanContinue { get; set; } = true;

        public string Guess(string guess)
        {
            if (!Validate(guess))
            {
                count++;
                if (count >= 6)
                {
                    CanContinue = false;
                }

                return "Wrong input";
            }

            string secret = secretGenerator.GenerateSecret();

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

            count++;

            if (count >= 6)
            {
                CanContinue = false;
            }

            Console.WriteLine("secret is: " + secret);
            return $"{bulls}A{cows}B";
        }

        private bool Validate(string guess)
        {
            if (guess.Length > 4 || guess.Length < 4)
            {
                return false;
            }

            for (int i = 0; i < guess.Length; i++)
            {
                if (guess.IndexOf(guess[i]) >= 0 && guess.IndexOf(guess[i]) != i)
                {
                    return false;
                }
            }

            return true;
        }
    }
}