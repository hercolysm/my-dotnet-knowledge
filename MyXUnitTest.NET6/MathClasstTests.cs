using MyLibraryClass.NET6.Classes;

namespace MyXUnitTest.NET6
{
    public class MathClasstTests
    {
        private readonly MathClass _mathClass;

        public MathClasstTests()
        {
            _mathClass = new MathClass();
        }

        [Fact]
        public void CalculateSquareRootTest()
        {
            double result = _mathClass.CalculateSquareRoot(4);

            Assert.Equal(2, result);
        }

        [Theory]
        [InlineData(2, 3, 8)]
        [InlineData(3, 2, 9)]
        public void CalculatePowerTest(int basenumber, int exponent, double expected)
        {
            double result = _mathClass.CalculatePower(basenumber, exponent);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, "zero")]
        public void NumberToTextTest(int number, string expected)
        {
            string result = _mathClass.NumberToText(number);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        public void IsEvenTest(int number)
        {
            bool result = _mathClass.IsEven(number);

            Assert.True(result);
        }

        [Theory]
        [InlineData(new int[] { 0, 2 })]
        [InlineData(new int[] { 4, 6, 8 })]
        public void IsEvenListTest(int[] numbers)
        {
            Assert.All(numbers, number => Assert.True(_mathClass.IsEven(number)));
        }
    }
}