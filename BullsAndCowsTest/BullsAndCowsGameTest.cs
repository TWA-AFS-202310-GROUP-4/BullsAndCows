using BullsAndCows;
using Moq;
using System;
using Xunit;

namespace BullsAndCowsTest
{
    public class BullsAndCowsGameTest
    {

        private Mock<SecretGenerator> mockedGenerator = new Mock<SecretGenerator>();

        [Fact]
        public void Should_return_4A0B_when_guess_given_same_number_secret()
        {
            string secret = "1234";
            var guessString = "1234";
            var expectGuessResult = "4A0B";

            mockedGenerator.Setup(x => x.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedGenerator.Object);
            var result = game.Guess(guessString);
            Assert.Equal(expectGuessResult, result);
        }

        [Fact]
        public void Should_return_2A0B_when_guess_given_2_correct_0_position_wrong()
        {
            string secret = "1234";
            var guessString = "1256";
            var expectGuessResult = "2A0B";

            mockedGenerator.Setup(x => x.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedGenerator.Object);
            var result = game.Guess(guessString);
            Assert.Equal(expectGuessResult, result);
        }
    }
}
