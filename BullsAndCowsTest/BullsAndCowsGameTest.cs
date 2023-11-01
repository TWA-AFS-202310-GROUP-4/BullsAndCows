using System.ComponentModel.DataAnnotations;
using BullsAndCows;
using Moq;
using Xunit;

namespace BullsAndCowsTest
{
    public class BullsAndCowsGameTest
    {
        [Fact]
        public void Should_create_BullsAndCowsGame()
        {
            var secretGenerator = new SecretGenerator();
            var game = new BullsAndCowsGame(secretGenerator);
            Assert.NotNull(game);
            Assert.True(game.CanContinue);
        }

        [Fact]
        public void Should_return_4A0B_when_guess_number_equal_secret_number()
        {
            var guessNumber = "1234";
            var secretNumber = "1234";
            // var secretGenerator = new SecretGenerator();
            var mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secretNumber);
            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            var ret = game.Guess(guessNumber);

            Assert.Equal("4A0B", ret);
        }

        [Theory]
        [InlineData("1536")]
        [InlineData("5634")]
        [InlineData("5236")]
        [InlineData("1564")]
        public void Should_return_2A0B_when_guess_number_different_secret_number(string guessNumber)
        {
            var secretNumber = "1234";
            // var secretGenerator = new SecretGenerator();
            var mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secretNumber);
            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            var ret = game.Guess(guessNumber);

            Assert.Equal("2A0B", ret);
        }

        [Theory]
        [InlineData("1562")]
        public void Should_return_1A1B_when_guess_number_different_secret_number(string guessNumber)
        {
            var secretNumber = "1234";
            // var secretGenerator = new SecretGenerator();
            var mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secretNumber);
            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            var ret = game.Guess(guessNumber);

            Assert.Equal("1A1B", ret);
        }

        [Theory]
        [InlineData("7569")]
        public void Should_return_0A0B_when_guess_number_different_secret_number(string guessNumber)
        {
            var secretNumber = "1234";
            // var secretGenerator = new SecretGenerator();
            var mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secretNumber);
            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            var ret = game.Guess(guessNumber);

            Assert.Equal("0A0B", ret);
        }
    }
}
