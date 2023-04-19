using Final_Project_VA;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;

namespace UnitTests.Tests
{
    public class UnitTest1 // :IClassFixture<WebApplicationFactory<Final_Project_VA.VACare>>
    {
        //private readonly WebApplicationFactory<Final_Project_VA.VACare> _factory;
        //public UnitTest1(WebApplicationFactory<Final_Project_VA.VACare> factory)
        //{
        //    _factory = factory;
        //}

        [Theory]
        [InlineData(true, true)]
        [InlineData(false, false)]
        public void MedicalServiceNOTAvailable(bool input, bool expected)
        {
            // Arrage
            bool service = new VACare();
            // Act CHANGES
            bool actual = service.Medic(input);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}