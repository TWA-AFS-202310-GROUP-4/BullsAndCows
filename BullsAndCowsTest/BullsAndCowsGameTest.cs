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

        [Fact]
        public void Should_return_2A0B_when_guess_number_different_secret_number()
        {
            var guessNumber = "1536";
            var secretNumber = "1234";
            // var secretGenerator = new SecretGenerator();
            var mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secretNumber);
            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            var ret = game.Guess(guessNumber);

            Assert.Equal("2A0B", ret);
        }
    }
}
