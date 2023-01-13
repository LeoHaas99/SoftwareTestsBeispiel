using Xunit;

namespace SoftwareTestsBeispiel
{
    public class AverageTest
    {
        [Fact]
        public void TestMedianForOddNumbersOfElements()
        {
            List<int> numbers = new List<int> { 12, 100, 13, 1532, 1 };
            double expected = 13;
            Average average = new Average();

            double actual = average.Median(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedianForEvenNumbersOfElements()
        {
            List<int> numbers = new List<int> { 12, 100, 13, 1532, 1, 3 };
            double expected = 12.5;
            Average average = new Average();

            double actual = average.Median(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedianForNoElements()
        {
            List<int> numbers = new List<int> { };
            Average average = new Average();

            Assert.Throws<ArgumentException>(() => average.Median(numbers));
        }
    }
}
