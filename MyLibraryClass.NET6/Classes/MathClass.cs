namespace MyLibraryClass.NET6.Classes
{
    public class MathClass
    {
        /// <summary>
        /// Calculates the square root of a number.
        /// </summary>
        /// <param name="number">The number to calculate the square root of.</param>
        /// <returns>The square root of the number.</returns>
        public double CalculateSquareRoot(int number)
        {
            return Math.Sqrt(number);
        }

        /// <summary>
        /// Calculates the power of a number.
        /// </summary>
        /// <param name="basenumber">The base number.</param>
        /// <param name="exponent">The exponent.</param>
        /// <returns>The result of raising the base number to the power of the exponent.</returns>
        public double CalculatePower(int basenumber, int exponent)
        {
            return Math.Pow(basenumber, exponent);
        }

        /// Converts a number to its corresponding text representation.
        /// </summary>
        /// <param name="number">The number to convert.</param>
        /// <returns>The text representation of the number.</returns>
        public string NumberToText(int number)
        {
            string[] units = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            return units[number];
        }

        /// <summary>
        /// Determines whether a number is even.
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <returns>True if the number is even, otherwise false.</returns>
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}