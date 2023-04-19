using Final_Project_VA;

namespace Final_Project_Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(true, true)]
        [InlineData(false, false)]
        public void Test1(bool expected, bool actual)
        {
            var vacare = new VACare();
            var actual = vacare.MedicalSeriveNOTAvailable(actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(29, 30, 19, 27, true)]
        public void TimeEligibilityTest(int aveDriveTimeMF, int aveDriveTimeSC, int aveWaitDayMF, int aveWaitDaySC, bool actual)
        {
            var vacare = new VACare();
            var actual = vacare.TimeEligibility(int aveDriveTimeMF, int aveDriveTimeSC, int aveWaitDayMF, int aveWaitDaySC, bool actual);
            Assert.Equal(expected, actual);
        }

    }


}