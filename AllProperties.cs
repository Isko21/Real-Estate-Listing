using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BigBanTheory_Project5
{
    class AllProperties
    {
        public static List<Property> allPropertiesBeforeTxtFile = new List<Property>();
        public static List<string> allLinesInTxt = File.ReadAllLines(@"Property.txt").ToList();


    }
}
