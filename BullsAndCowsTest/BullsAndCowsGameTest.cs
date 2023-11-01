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
        public void Should_return_4A0B_when_guess_given_string_same_secretes()
        {
            //given
            var guessString = "1234";
            var secret = "1234";

            Mock<SecretGenerator> mockGenerator = new Mock<SecretGenerator>();
            mockGenerator.Setup(m => m.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockGenerator.Object);

            //when
            var res = game.Guess(guessString);

            //then
            Assert.Equal("4A0B", res);
        }
    }
}
