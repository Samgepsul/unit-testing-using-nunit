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
            int[] numbers = { -2, -1, 0, 3, 5 };
            int expectedIndex = 3;

            int index = NumberProcessor.FindFirstPositive(numbers);
            Assert.AreEqual(expectedIndex, index);
        }

        [Test]
        public void FindFirstPositive_ShouldReturnNegativeWhenNoPositiveNumber()
        {
            int[] numbers = { -2, -1, 0, -3, -5 };
            int index = NumberProcessor.FindFirstPositive(numbers);

            Assert.AreEqual(-1, index);
        }

        [Test]
        public void SumBetweenFirstAndLastPositive_ShouldReturnCorrectSum()
        {
            int[] numbers = { -2, 1, 0, -3, 5 };
            double expectedSum = -2;

            double sum = NumberProcessor.SumBetweenFirstAndLastPositive(numbers);

            Assert.AreEqual(expectedSum, sum);
        }

        [Test]
        public void MoveZeroesToFront_ShouldMoveAllZeros()
        {
            int[] numbers = { -2, 0, 3, 0, 5 };
            int[] expected = { 0, 0, -2, 3, 5 };

            NumberProcessor.MoveZeroesToFront(numbers);

            Assert.IsFalse(expected.SequenceEqual(numbers));
        }
    }
}
