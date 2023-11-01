﻿using System;

namespace BullsAndCows
{
    public class BullsAndCowsGame
    {
        private readonly SecretGenerator secretGenerator;
        private readonly string secret;
        public BullsAndCowsGame(SecretGenerator secretGenerator)
        {
            this.secretGenerator = secretGenerator;
            secret = secretGenerator.GenerateSecret();
        }

        public bool CanContinue => true;

        public string Guess(string guess)
        {
            int bulls = 0;
            if (guess.Equals(secret))
            {
                return "4A0B";
            }

            for (var i = 0; i < secret.Length; i++)
            {
                if (secret[i] == guess[i])
                {
                    bulls ++;
                }
            }

            return $"{bulls}A0B";
        }
    }
}