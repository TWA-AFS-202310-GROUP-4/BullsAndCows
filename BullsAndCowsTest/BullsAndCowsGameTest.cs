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

        [Theory]
        [InlineData("1243")]
        [InlineData("2134")]
        [InlineData("1324")]
        public void Should_return_2A2B_when_guess_given_all_digit_values_correct_but_positions_partial_correct(string guessString)
        {
            //given
            var secret = "1234";

            Mock<SecretGenerator> mockGenerator = new Mock<SecretGenerator>();
            mockGenerator.Setup(m => m.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockGenerator.Object);

            //when
            var res = game.Guess(guessString);

            //then
            Assert.Equal("2A2B", res);
        }

        [Theory]
        [InlineData("1672")]
        [InlineData("4268")]
        [InlineData("1528")]
        public void Should_return_1A1B_when_guess_given_digit_values_partial_correct_and_positions_partial_correct(string guessString)
        {
            //given
            var secret = "1234";

            Mock<SecretGenerator> mockGenerator = new Mock<SecretGenerator>();
            mockGenerator.Setup(m => m.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockGenerator.Object);

            //when
            var res = game.Guess(guessString);

            //then
            Assert.Equal("1A1B", res);
        }

        [Theory]
        [InlineData("4356")]
        [InlineData("5612")]
        [InlineData("5128")]
        public void Should_return_0A2B_when_guess_given_digit_values_partial_correct_and_positions_all_incorrect(string guessString)
        {
            //given
            var secret = "1234";

            Mock<SecretGenerator> mockGenerator = new Mock<SecretGenerator>();
            mockGenerator.Setup(m => m.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockGenerator.Object);

            //when
            var res = game.Guess(guessString);

            //then
            Assert.Equal("0A2B", res);
        }

        [Theory]
        [InlineData("4321")]
        [InlineData("2143")]
        [InlineData("3142")]
        public void Should_return_0A4B_when_guess_given_digit_values_all_correct_and_positions_all_incorrect(string guessString)
        {
            //given
            var secret = "1234";

            Mock<SecretGenerator> mockGenerator = new Mock<SecretGenerator>();
            mockGenerator.Setup(m => m.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockGenerator.Object);

            //when
            var res = game.Guess(guessString);

            //then
            Assert.Equal("0A4B", res);
        }

        [Theory]
        [InlineData("5678")]
        [InlineData("0567")]
        [InlineData("9876")]
        public void Should_return_0A0B_when_guess_given_digit_values_and_positions_all_incorrect(string guessString)
        {
            //given
            var secret = "1234";

            Mock<SecretGenerator> mockGenerator = new Mock<SecretGenerator>();
            mockGenerator.Setup(m => m.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockGenerator.Object);

            //when
            var res = game.Guess(guessString);

            //then
            Assert.Equal("0A0B", res);
        }
    }
}
