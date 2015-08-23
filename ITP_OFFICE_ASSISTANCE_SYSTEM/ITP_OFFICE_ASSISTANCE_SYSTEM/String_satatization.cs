using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ITP_OFFICE_ASSISTANCE_SYSTEM
{
    class String_satatization
    {
        //by MSDN http://msdn.microsoft.com/en-us/library/844skk0h(v=vs.71).aspx
        public static string sanitize (string strIn)
        {
            // Replace non alphanumeric characters with empty strings.
            return Regex.Replace(strIn, @"[^\w\.]", "");
        }
        
        public bool analyze(string strIn)
        {
            // Check if there are any non word characters.
            return Regex.IsMatch(strIn, @"[^\?/;:`~!@#$%^&*()_+\-=\\'""']");
        }

        //public void 

    }
}
