using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MPowerPrivate;

namespace MPowerMiniUssd.Models
{
    public class Util
    {
        public static string UnlockKey = "";
        public static MPower MPowerInstance(string mobileNumber)
        {
            return new MPower("0" + mobileNumber.Substring(3));
        }
    }
}
