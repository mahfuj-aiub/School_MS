using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace School_MS
{
    static class Validation_Check
    {
        public static string email_Pattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
        public static string name_Pattern = @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$";
        public static string number_Pattern = @"\+?(88)?0?1[356789][0-9]{8}\b";
        public static bool check_Email_Pattern(string s)
        {
            return Regex.IsMatch(s, email_Pattern);
        }
        public static bool check_Name_Pattern(string s)
        {
            return Regex.IsMatch(s, name_Pattern);
        }
        public static bool check_Number_Pattern(string s)
        {
            return Regex.IsMatch(s, number_Pattern);
        }

    }
}
