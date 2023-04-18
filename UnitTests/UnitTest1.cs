

namespace UnitTests.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(true, true)]
        [InlineData(false, false)]
        public void MedicalServiceNOTAvailable(bool input, bool expected)
        {
            // Arrage
            bool service = new VACare();
            // Act CHANGES
            bool actual = service.MedicalServiceNOTAvailable(input);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}