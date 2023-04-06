namespace Percentake.Math.Extensions
{
    public static class DoubleExtension
    {
        /// <summary>
        ///     Rounds a double-precision floating-point value to a 4 digit value.
        /// </summary>
        /// <param name="a">A double-precision floating-point number to be rounded.</param>
        /// <returns>
        ///     The integer nearest . If the fractional component of  is halfway between two integers, one of which is even
        ///     and the other odd, then the even number is returned. Note that this method returns a  instead of an integral
        ///     type.
        /// </returns>
        public static Double PercentRound(this Double a)
        {
            return System.Math.Round(a, 4);
        }

        /// <summary>
        ///     Rounds a double-precision floating-point value to a specified number of fractional digits.
        /// </summary>
        /// <param name="a">A double-precision floating-point number to be rounded.</param>
        /// <param name="digits">The number of fractional digits in the return value.</param>
        /// <returns>The number nearest to  that contains a number of fractional digits equal to .</returns>
        public static Double PercentRound(this Double a, Int32 digits)
        {
            return System.Math.Round(a, digits);
        }
    }
}
