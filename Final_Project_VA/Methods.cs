namespace Final_Project_VA
{
    public class Methods
    {
        public static bool MedicalSeriveNOTAvailable(bool answerQ1)
        {
            bool question1Answer = answerQ1;

            if (question1Answer == true)
            {
                Console.WriteLine("You may qualify for community care");
            }

            return question1Answer;
        }

        public static bool NoVAMedicalFacility(string veteranState)
        {
            string[] statesWithoutVAMed = { "Alaska", "Hawaii", "New Hampshire", "Guam", "American Samoa", "Northern Mariana Islands", "U.S. Virgin Islands" };
            bool stateHasVAMed = Array.Exists(statesWithoutVAMed, state => state.Equals(veteranState, StringComparison.OrdinalIgnoreCase));

            if (stateHasVAMed == false)
            {
                Console.WriteLine("You may qualify for community care");
            }

            return stateHasVAMed;
        }

        public static bool DistanceEligibility(double answerQ3)
        {
            var veteranState = "Montana";
            var vetLocation = answerQ3;
            var timeAtVetLocation = "06/05/2018";
            string[] stateswithLowestPop = { "North Dakota", "South Dakota", "Montana", "Alaska", "Wyoming" };
            bool livesInLowDensity = Array.Exists(stateswithLowestPop, state => state.Equals(veteranState, StringComparison.OrdinalIgnoreCase));



            // Check if veteran is eligible under the 40-mile criterion and is continuing to reside in a qualifying location
            if (timeAtVetLocation != "06/06/2018" && vetLocation > 40)
            {
                // Check if veteran is residing in one of the lowest population density states or has received care between certain dates and requires care before June 2020
                if (livesInLowDensity == true)
                {
                    Console.WriteLine("You may qualify for community care");
                }
            }

            return false;
        }

        public static string DriveTime(string answer4)
        {
            throw new NotImplementedException();
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
