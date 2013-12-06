using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseholdLedger.Utility
{
    public static class StringUtil
    {
        public static string EmptyOrValue(string s) 
        {
            if (s == null)
            {
                return string.Empty;
            }
            else {
                return s;
            }
        }

        public static int IntZeroOrValue(string s) 
        {
            if (s == null || s.Length ==0)
            {
                return 0;
            }
            else {
                return int.Parse(s);
            }
        }

        public static decimal DecimalZeroOrValue(string s) 
        {
            if (s == null || s.Length == 0)
            {
                return 0;
            }
            else
            {
                return decimal.Parse(s);
            }
        }

        public static DateTime DateTimeNewOrValue(string s)
        {
            if (s == null || s.Length == 0)
            {
                return new DateTime();
            }
            else 
            {
                return DateTime.Parse(s);
            }
        }
        

    }
}