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
        public void Should_return_4A0B_when_guess_number_and_secret_are_same()
        {
            //Given
            string guessNumber = "1234";
            string screatNumber = "1234";

            //var secretGenerator = new SecretGenerator();
            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generate => generate.GenerateSecret()).Returns(screatNumber);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //when
            string result = game.Guess(guessNumber);
            //then
            Assert.Equal("4A0B", result);
        }
    }
}
