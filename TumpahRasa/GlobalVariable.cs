using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TumpahRasa
{
    public class GlobalVariable
    {
        public static string connString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        public static int adminId = 1;
        public static int memberId = 1;
    }
}