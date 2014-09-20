using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UssdFramework;

namespace MPowerMiniUssd.Models.ScreenResponses
{
    public class Notices
    {
        public static async Task<UssdResponse> GeneralGreeting(Session session)
        {
            return UssdResponse.Notice("Hello, boss!");
        }

        public async static Task<UssdResponse> AccountInfo(Session session)
        {
            var mpower = Util.MPowerInstance(session.Mobile);
            var response = await mpower.UserAccountCheck(Util.UnlockKey);
            return UssdResponse.Notice(String.Format("Current Balance: {0}" + Environment.NewLine
                                                     + "Name: {1}" + Environment.NewLine
                                                     + "Username: {2}" + Environment.NewLine
                                                     + "Email: {3}" + Environment.NewLine
                , response.Data.Balance, response.Data.Name, response.Data.Username, response.Data.Email));
        }
    }
}