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

        [Theory]
        [InlineData("1256")]
        public void Should_return_2A0B_when_guess_given_2_correct_0_position_wrong(string guessString)
        {
            string secret = "1234";
            var expectGuessResult = "2A0B";

            mockedGenerator.Setup(x => x.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedGenerator.Object);
            var result = game.Guess(guessString);
            Assert.Equal(expectGuessResult, result);
        }

        // 0A0B
        // 0A4B
        // 2A2B
        // 1A1B
        // 0A2B
        [Theory]
        [InlineData("5678")]
        public void Should_return_0A0B_when_guess_given_0_correct_0_position_wrong(string guessString)
        {
            string secret = "1234";
            var expectGuessResult = "0A0B";

            mockedGenerator.Setup(x => x.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedGenerator.Object);
            var result = game.Guess(guessString);
            Assert.Equal(expectGuessResult, result);
        }
    }
}
