using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UssdFramework;

namespace MPowerMiniUssd.Models
{
    public class Screens
    {
        public static Dictionary<string, UssdScreen> All = new Dictionary<string, UssdScreen>();

        static Screens()
        {
            All.Add("1", UssdScreen.Menu("Main menu", ScreenResponses.Menus.MainMenu));
            All.Add("1.1", UssdScreen.Notice("Account info", ScreenResponses.Notices.AccountInfo));
            All.Add("1.2", UssdScreen.Menu("Corner Shop menu", ScreenResponses.Menus.CornerShopMenu));
            All.Add("1.2.1", UssdScreen.Input("Airtime topup"
                , new List<UssdInput>()
                {
                    new UssdInput("Network", new List<UssdInputOption>()
                    {
                        new UssdInputOption("Airtel"),
                        new UssdInputOption("MTN"),
                        new UssdInputOption("Glo"),
                        new UssdInputOption("Tigo"),
                        new UssdInputOption("Vodafone")
                    }),
                    new UssdInput("Mobile", "Mobile Number"),
                    new UssdInput("Amount"),
                    new UssdInput("Pin", "MPower Pin")
                }, InputProcessors.AirtimeTopup));
            All.Add("1.2.2", UssdScreen.Input("Check ECG bill"
                , new List<UssdInput>()
                {
                    new UssdInput("AccountNumber", "Account Number")
                }, InputProcessors.CheckEcg));
        }
    }
}