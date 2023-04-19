namespace Final_Project_VA
{
    public class Methods
    {
        //This method requires a specific question
        public  bool MedicalSeriveNOTAvailable(bool answerQ1)
        {
            if (answerQ1 == true)
            {
                Console.WriteLine("You may qualify for community care");
            }

            return answerQ1;
        }

        //For this method we need to collect veteran state or create a null catch
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

        //This method will need to pass a string for the date the veteran moved into their current address.
        public static bool GrandfatherEligibility(double answerQ3)
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
                    Console.WriteLine("You may qualify for Community Care");
                    return true;
                }
            }
            return false;
        }

        //I'm not sure how tocalculate the average drive times with the API. We might have to split up drivetime and waiting days based on the API.
        public static bool TimeEligibility(int aveDriveTimeMF, int aveDriveTimeSC, int aveWaitDayMF, int aveWaitDaySC)
        {
            if (aveDriveTimeMF > 30 || aveDriveTimeSC > 60 || aveWaitDayMF > 20 || aveWaitDaySC > 28)
            {
                Console.WriteLine("You may qualify for Community Care");
                return true; 
            }
            else
            return false;
        }

        //This method requires a specific question 
        public static bool BestMedicalInterest(bool answerQ5)
        {
            if (answerQ5 == true)
            {
                Console.WriteLine("You may qualify for community care");
            }

            return answerQ5;
        }

        //Notes This method requires a specific question
        public static bool QualityStandards(bool answerQ6)
        {
            if (answerQ6 == true)
            {
                Console.WriteLine("You may qualify for community care");
            }
            return answerQ6;
        }
    }





}
