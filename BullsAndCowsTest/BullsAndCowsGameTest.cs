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
        public void Should_return_4A0B_when_guess_given_same_number_secret()
        {
            string secret = "1234";
            var guessString = "1234";
            var expectGuessResult = "4A0B";

            var mockedGenerator = new Mock<SecretGenerator>();
            mockedGenerator.Setup(x => x.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedGenerator.Object);
            var result = game.Guess(guessString);
            Assert.Equal(expectGuessResult, result);
        }
    }
}
