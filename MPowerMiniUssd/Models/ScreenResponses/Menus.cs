using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UssdFramework;

namespace MPowerMiniUssd.Models.ScreenResponses
{
    public class Menus
    {
        public async static Task<UssdResponse> MainMenu(Session session)
        {
            var mpower = Util.MPowerInstance(session.Mobile);
            var response = await mpower.UserAccountCheck(Util.UnlockKey);
            return UssdResponse.Menu(String.Format("Welcome to {0}, {1}" + Environment.NewLine
                                                   + "1. Account info" + Environment.NewLine
                                                   + "2. Corner Shop" + Environment.NewLine
                , session.AppName, response.Data.Name));
        }

        public async static Task<UssdResponse> CornerShopMenu(Session session)
        {
            return UssdResponse.Menu("Corner Shop" + Environment.NewLine
                                     + "1. Topup airtime" + Environment.NewLine
                                     + "2. Check ECG bill" + Environment.NewLine
                                     + "0. Go back");
        }
    }
}