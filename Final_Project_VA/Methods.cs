namespace Final_Project_VA
{
    public class Methods
    {
        //Specific Question required
        public static bool MedicalSeriveNOTAvailable(bool answerQ1)
        {
           
            if (answerQ1 == true)
            {
                Console.WriteLine("You may qualify for community care");
            }

            return answerQ1;
        }

        //
        public static bool NoVAMedicalFacility(string vetState)
        {
            string[] statesWithoutVAMed = { "Alaska", "Hawaii", "New Hampshire", "Guam", "American Samoa", "Northern Mariana Islands", "U.S. Virgin Islands" };
            bool stateHasVAMed = Array.Exists(statesWithoutVAMed, state => state.Equals(vetState, StringComparison.OrdinalIgnoreCase));

            if (stateHasVAMed == false)
            {
                Console.WriteLine("You may qualify for community care");
            }

            return stateHasVAMed;
        }

        //It may need to pass in a string for the date the veteran moved into their current address
        public static bool DistanceEligibility(double answerQ3)
        {
            string movedInDate = "01/01/2016";
            var vetState = "Montana";
            var vetLocation = answerQ3;
            var timeAtAddress = DateTime.Parse(movedInDate);
            string[] stateswithLowestPop = { "North Dakota", "South Dakota", "Montana", "Alaska", "Wyoming" };
            bool livesInLowDensity = Array.Exists(stateswithLowestPop, state => state.Equals(vetState, StringComparison.OrdinalIgnoreCase));



            // Check if veteran is eligible under the 40-mile criterion and is continuing to reside in a qualifying location
            if (timeAtAddress <= DateTime.Parse("06/06/2018") && vetLocation > 40)
            {
                // Check if veteran is residing top5 lowest population density states or has received care between certain dates and requires care before June 2020
                if (livesInLowDensity || /*(DateTime.Parse*/(timeAtAddress >= DateTime.Parse("06/06/2017") && /*DateTime.Parse*/(timeAtAddress) <= DateTime.Parse("06/06/2018")))
                {
                    Console.WriteLine("You may qualify for community care");
                    return true;
                }
            }
            return false;
        }

        public static bool IsEligibleForCommunityCare(int aveDriveTime, int aveWaitTime)
        {
            // Check if eligible based on average drive time to VA medical facility
            bool isEligibleBasedOnDriveTime = aveDriveTime > 30 || aveDriveTime > 60;

            // Check if eligible based on appointment wait time at VA medical facility
            bool isEligibleBasedOnAppointmentWaitTime = aveWaitTime > 20 || aveWaitTime > 28;

            // Determine overall eligibility for community care
            if (isEligibleBasedOnDriveTime || isEligibleBasedOnAppointmentWaitTime)
            {
                return true;
            }

            return false;
        }


        public static bool BestMedicalInterest(string answer5)
        {
            throw new NotImplementedException();
        }

        public static void QualityStandards()
        {
            throw new NotImplementedException();
        }
    }





}
