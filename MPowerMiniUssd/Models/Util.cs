using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MPowerPrivate;

namespace MPowerMiniUssd.Models
{
    public class Util
    {
        public static string UnlockKey = "6KZ4HJFEDG6XHKVKPX9Q2ZYTLZ4CV4QG";
        public static MPower MPowerInstance(string mobileNumber)
        {
            return new MPower("0" + mobileNumber.Substring(3));
        }
    }
}