using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBanTheory_Project5
{
    class Reader
    {
        public static string FirstRemover(string result)
        {
            int r = result.IndexOf(" ") + 1;
            result = result.Substring(r);
            return result;
        }
        public static string LastRemover(string result)
        {
            result = result.Remove(result.LastIndexOf(' ')).TrimEnd();
            return result;
        }

    }
}
