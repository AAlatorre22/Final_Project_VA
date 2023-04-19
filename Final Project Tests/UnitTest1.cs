using Final_Project_VA;

namespace Final_Project_Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(true, true)]
        [InlineData(false, false)]
        public void Test1(bool test, bool expected)
        {
            var vacare = new VACare();
            var actual = vacare.MedicalSeriveNOTAvailable(test);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(29, 30, 19, 27, true)]
        public void TimeEligibilityTest(int aveDriveTimeMF, int aveDriveTimeSC, int aveWaitDayMF, int aveWaitDaySC, bool expected)
        {
            var vacare = new VACare();
            var actual = VACare.TimeEligibility( aveDriveTimeMF,  aveDriveTimeSC,  aveWaitDayMF,  aveWaitDaySC);
            Assert.Equal(expected, actual);
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

    }


}