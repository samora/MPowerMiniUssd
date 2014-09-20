using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UssdFramework;

namespace MPowerMiniUssd.Models
{
    public class InputProcessors
    {
        public static async Task<UssdResponse> CustomGreeting(Session session, Dictionary<string, string> data)
        {
            return UssdResponse.Input(String.Format("Hello, {0} {1} {2}"
                , data["Title"], data["FirstName"], data["LastName"]));
        }

        public async static Task<UssdResponse> AirtimeTopup(Session session, Dictionary<string, string> data)
        {
            var mpower = Util.MPowerInstance(session.Mobile);
            var response = await mpower.ServicesAirtime(data["Network"]
                , data["Mobile"], Convert.ToDecimal(data["Amount"]),data["Pin"]);
            return UssdResponse.Input(response.Message);
        }

        public async static Task<UssdResponse> CheckEcg(Session session, Dictionary<string, string> data)
        {
            var mpower = Util.MPowerInstance(session.Mobile);
            var response = await mpower.ServicesVerifyEcgBill(data["AccountNumber"]);
            return UssdResponse.Input(response.Message);
        }
    }
}