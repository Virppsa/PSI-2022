using MailRemoverAPI.Services;
using Xunit;
using Assert = Xunit.Assert;
using TheoryAttribute = Xunit.TheoryAttribute;

namespace UnitTests
{
    [TestClass]
    public class Co2FootprintCalcTests
    {
        Co2FootprintCalc co2FootprintCalc;

        [Theory]
        [InlineData(20, 0.38)]
        [InlineData(1235, 23.465)]
        [InlineData(1, 0.019)]
        public void Co2toKg_Works(int input, double expected)
        {
            //Arrange
            co2FootprintCalc = new Co2FootprintCalc();

            //Act
            var actual = co2FootprintCalc.Co2toKg(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 19000)]
        [InlineData(50, 950000)]
        [InlineData(67, 1273000)]
        public void ToGram_Works(int input, long expected)
        {
            //Arrange
            co2FootprintCalc = new Co2FootprintCalc();

            //Act
            var actual = co2FootprintCalc.ToGrams(input).Result;
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(27, 0.000000513)]
        public void ToTonns_Works(int input, double expected)
        {
            //Arrange
            co2FootprintCalc = new Co2FootprintCalc();

            //Act
            var actual = co2FootprintCalc.ToTonns(input).Result;

            //Assert
            Assert.Equal(actual, expected);
        }
    }
}