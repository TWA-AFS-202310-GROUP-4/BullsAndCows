using BullsAndCows;
using Moq;
using Xunit;

namespace BullsAndCowsTest
{
    public class BullsAndCowsGameTest
    {
        [Fact]
        public void Should_return_4A0B_when_guess_given_guess_number_and_secret_are_same()
        {
            //Given
            string guessNumber = "1234";
            string secret = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("4A0B", result);
        }


        [Theory]
        [InlineData("1234")]
        [InlineData("1299")]
        [InlineData("1279")]
        public void Should_return_2A0B_when_guess_given_position_and_digits_are_partially_same(string secret)
        {
            //Given
            string guessNumber = "1258";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("2A0B", result);
        }

        [Theory]
        [InlineData("1084")]
        [InlineData("1089")]
        [InlineData("1089")]
        public void Should_return_1A1B_when_guess_given_position_and_digits_are_partially_same(string secret)
        {
            //Given
            string guessNumber = "1258";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("1A1B", result);
        }

        [Theory]
        [InlineData("6666")]
        [InlineData("4466")]
        [InlineData("9933")]
        public void Should_return_0A0B_when_guess_given_position_and_digits_are_both_not_correct(string secret)
        {
            //Given
            string guessNumber = "1258";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("0A0B", result);
        }


        [Theory]
        [InlineData("2185")]
        [InlineData("8521")]
        [InlineData("8512")]
        public void Should_return_0A4B_when_guess_given_digits_are_correct_positions_are_wrong(string secret)
        {
            //Given
            string guessNumber = "1258";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("0A4B", result);
        }

        [Theory]
        [InlineData("1285")]
        [InlineData("2158")]
        [InlineData("8251")]
        public void Should_return_2A2B_when_guess_given_digits_and_positions_are_partially_correct(string secret)
        {
            //Given
            string guessNumber = "1258";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("2A2B", result);
        }
    }
}
