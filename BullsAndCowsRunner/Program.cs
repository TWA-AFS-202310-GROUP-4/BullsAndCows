using System;
using System.Net.Sockets;
using BullsAndCows;
using Moq;

namespace BullsAndCowsRunner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Mock<SecretGenerator> mockGenerator = new Mock<SecretGenerator>();
            mockGenerator.Setup(m => m.GenerateSecret()).Returns("1234");

            BullsAndCowsGame game = new BullsAndCowsGame(mockGenerator.Object);
            while (game.CanContinue)
            {
                var input = Console.ReadLine();
                var output = game.Guess(input);
                Console.WriteLine(output);
            }

            Console.WriteLine("Game Over");
        }
    }
}