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

        [Theory]
        [InlineData("1256")]
        [InlineData("5634")]
        [InlineData("1564")]
        [InlineData("5236")]

        public void Should_return_2A0B_when_guess_given_digit_and_position_are_partial_right(string guessNumber)
        {
            //Given
            //string guessNumber = "1234";
            string screatNumber = "1234";

            //var secretGenerator = new SecretGenerator();
            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generate => generate.GenerateSecret()).Returns(screatNumber);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //when
            string result = game.Guess(guessNumber);
            //then
            Assert.Equal("2A0B", result);
        }

        [Theory]
        [InlineData("1356")]
        public void Should_return_1A1B_when_guess_given_digit_and_position_are_partial_right(string guessNumber)
        {
            //Given
            //string guessNumber = "1234";
            string screatNumber = "1234";

            //var secretGenerator = new SecretGenerator();
            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generate => generate.GenerateSecret()).Returns(screatNumber);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //when
            string result = game.Guess(guessNumber);
            //then
            Assert.Equal("1A1B", result);
        }

        [Theory]
        [InlineData("6789")]
        public void Should_return_0A0B_when_guess_given_digit_and_position_are_all_wrong(string guessNumber)
        {
            //Given
            //string guessNumber = "1234";
            string screatNumber = "1234";

            //var secretGenerator = new SecretGenerator();
            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generate => generate.GenerateSecret()).Returns(screatNumber);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //when
            string result = game.Guess(guessNumber);
            //then
            Assert.Equal("0A0B", result);
        }

        [Theory]
        [InlineData("3487")]
        public void Should_return_0A2B_when_guess_given_position_are_partial_wrong(string guessNumber)
        {
            //Given
            //string guessNumber = "1234";
            string screatNumber = "1234";

            //var secretGenerator = new SecretGenerator();
            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generate => generate.GenerateSecret()).Returns(screatNumber);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //when
            string result = game.Guess(guessNumber);
            //then
            Assert.Equal("0A2B", result);
        }

        [Theory]
        [InlineData("4321")]
        public void Should_return_0A4B_when_guess_given_all_digit_values_correct_but_all_position_are_wrong(string guessNumber)
        {
            //Given
            //string guessNumber = "1234";
            string screatNumber = "1234";

            //var secretGenerator = new SecretGenerator();
            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generate => generate.GenerateSecret()).Returns(screatNumber);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //when
            string result = game.Guess(guessNumber);
            //then
            Assert.Equal("0A4B", result);
        }

        [Theory]
        [InlineData("1243")]
        public void Should_return_2A2B_when_guess_given_all_digit_values_correct_but_partially_position_are_wrong(string guessNumber)
        {
            //Given
            //string guessNumber = "1234";
            string screatNumber = "1234";

            //var secretGenerator = new SecretGenerator();
            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generate => generate.GenerateSecret()).Returns(screatNumber);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //when
            string result = game.Guess(guessNumber);
            //then
            Assert.Equal("2A2B", result);
        }
    }
}
