using BullsAndCows;
using Moq;
using Xunit;

namespace BullsAndCowsTest
{
    public class BullsAndCowsGameTest
    {
        [Fact]
        public void Should_return_4A0B_when_guess_number_and_secrete_are_same()
        {
            //Given
            string guessNumber = "1234";
            string secrete = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secrete);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("4A0B", result);
        }

        [Theory]
        [InlineData("1256")]
        [InlineData("5634")]
        [InlineData("5236")]
        [InlineData("1584")]
        public void Should_return_2A0B_when_guess_number_and_secrete_are_partially_same(string guessNumber)
        {
            //Given
            string secrete = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secrete);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("2A0B", result);
        }

        [Theory]
        [InlineData("7249")]
        [InlineData("9247")]
        public void Should_return_1A1B_when_guess_number_and_secrete_are_partially_same(string guessNumber)
        {
            //Given
            string secrete = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secrete);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("1A1B", result);
        }

        [Theory]
        [InlineData("5678")]
        public void Should_return_0A0B_when_guess_number_and_secrete_are_partially_same(string guessNumber)
        {
            //Given
            string secrete = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secrete);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("0A0B", result);
        }

        [Theory]
        [InlineData("4321")]
        [InlineData("2341")]
        public void Should_return_0A4B_when_guess_number_and_secrete_are_partially_same(string guessNumber)
        {
            //Given
            string secrete = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secrete);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("0A4B", result);
        }
    }
}
