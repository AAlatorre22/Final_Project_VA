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
            var actual = vacare.MedicalSeriveNOTAvailable(actual);
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

        public void NoVAMedicalFacilityTest (string vetState, bool expected)
        {
<<<<<<< HEAD
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
        public void TimeEligibilityTest(int aveDriveTimeMF, int aveDriveTimeSC, int aveWaitDayMF, int aveWaitDaySC, bool expected)
        {
            //arrange
            //VACare eligible = new VACare();
            //act
            var actual = VACare.TimeEligibility(aveDriveTimeMF, aveDriveTimeSC, aveWaitDayMF, aveWaitDaySC);
            //assert
=======
            var vacare = new VACare();
            var actual = vacare.TimeEligibility(int aveDriveTimeMF, int aveDriveTimeSC, int aveWaitDayMF, int aveWaitDaySC, bool actual);
>>>>>>> f6a7f29687e00b751385316d966ba67170807ea6
            Assert.Equal(expected, actual);
        }

    }


}