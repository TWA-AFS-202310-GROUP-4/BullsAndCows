using BullsAndCows;
using Moq;
using Xunit;

namespace BullsAndCowsTest
{
    public class BullsAndCowsGameTest
    {
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

        [Theory]
        [InlineData("1256")]
        [InlineData("7834")]
        [InlineData("5236")]
        public void Should_return_2A0B_when_guess_given_position_partial_secretes(string guessString)
        {
            //given
            var secret = "1234";

            Mock<SecretGenerator> mockGenerator = new Mock<SecretGenerator>();
            mockGenerator.Setup(m => m.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockGenerator.Object);

            //when
            var res = game.Guess(guessString);

            //then
            Assert.Equal("2A0B", res);
        }
    }
}
