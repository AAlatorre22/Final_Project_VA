using Final_Project_VA;

namespace Final_Project_Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(true, true)]
        [InlineData(false, false)]
        public void Test1(bool actual, bool expected)
        {
            var vacare = new VACare();
            var result = vacare.MedicalSeriveNOTAvailable(actual);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Alaska", true)]
        [InlineData("new hampshire", true)]
        [InlineData("Northern Mariana Islands", true)]
        [InlineData("u.s. virgin islands", true)]
        [InlineData("guam", true)]
        [InlineData("hawaii", true)]
        [InlineData("american samoa", true)]
        [InlineData("california", false)]

        public void NoVAMedicalFacilityTest(string vetState, bool expected)
        {
            //arrange
            var VACare = new VACare();
            //act
            var actual = VACare.NoVAMedicalFacility(vetState);
            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(29, 30, 19, 27, false)]
        [InlineData(35, 65, 25, 29, true)]
        [InlineData(35, 55, 15, 20, true)]
        [InlineData(25, 65, 10, 16, true)]
        [InlineData(20, 65, 12, 20, true)]
        [InlineData(15, 15, 15, 9, false)]
        public void TimeEligibilityTest(int aveDriveTimeMF, int aveDriveTimeSC, int aveWaitDayMF, int aveWaitDaySC, bool expected)
        {
            //arrange
            //VACare eligible = new VACare();
            //act
            var actual = VACare.TimeEligibility(aveDriveTimeMF, aveDriveTimeSC, aveWaitDayMF, aveWaitDaySC);
            //assert
            Assert.Equal(expected, actual);
        }

    }


}