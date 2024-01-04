using NUnit.Framework;
using System.Linq;

namespace NumberProcessingTests
{
    [TestFixture]
    public class NumberProcessorTests
    {
        [Test]
        public void FindFirstPositive_ShouldReturnIndexOfFirstPositiveNumber()
        {
            // Arrange
            int[] numbers = { -2, -1, 0, 3, 5 };
            int expectedIndex = 3;

            // Act
            int index = NumberProcessor.FindFirstPositive(numbers);

            // Assert
            Assert.AreEqual(expectedIndex, index);
        }

        [Test]
        public void FindFirstPositive_ShouldReturnNegativeWhenNoPositiveNumber()
        {
            // Arrange
            int[] numbers = { -2, -1, 0, -3, -5 };

            // Act
            int index = NumberProcessor.FindFirstPositive(numbers);

            // Assert
            Assert.AreEqual(-1, index);
        }

        [Test]
        public void SumBetweenFirstAndLastPositive_ShouldReturnCorrectSum()
        {
            // Arrange
            int[] numbers = { -2, 1, 0, -3, 5 };
            double expectedSum = -3; // No numbers between first and last positive

            // Act
            double sum = NumberProcessor.SumBetweenFirstAndLastPositive(numbers);

            // Assert
            Assert.AreEqual(expectedSum, sum);
        }

        [Test]
        public void MoveZeroesToFront_ShouldMoveAllZeros()
        {
            // Arrange
            int[] numbers = { -2, 0, 3, 0, 5 };
            int[] expected = { 0, 0, -2, 3, 5 };

            // Act
            NumberProcessor.MoveZeroesToFront(numbers);

            // Assert
            Assert.IsFalse(expected.SequenceEqual(numbers));
        }
    }
}
