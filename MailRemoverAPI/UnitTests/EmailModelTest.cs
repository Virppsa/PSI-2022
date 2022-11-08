using MailRemoverAPI.Entities;
using Xunit;
using Assert = Xunit.Assert;

namespace UnitTests
{
    [TestClass]
    public class EmailModelTest
    {
        [Theory]
        [InlineData("Type")]
        [InlineData("Address")]
        [InlineData("Token")]
        [InlineData("UserId")]
        [InlineData("User")]
        public void EmailModel_HasProperty_True(string input)
        {
            //Arrange

            //Act
            var actual = typeof(Email).GetProperty(input);

            //Assert
            Assert.NotNull(actual);
        }
    }
}
