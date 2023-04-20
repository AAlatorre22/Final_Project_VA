using Newtonsoft.Json.Linq;

namespace Final_Project_VA
{
    public class FacilityAPI
    {

        public static string State(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var descript = JObject.Parse(response)["data"][0]["attributes"]["address"]["state"].ToString();
            return descript;
        }





    }
}
