using System;
using System.Collections.Generic;
using System.Text;

namespace IntroDel1
{
    class Convertstuff
    {
        static void convertTest()
        {
            //To-String
            var x = true;
            string s = "" + x;
            // Vil gjøre True om til string


            double d = 13.37;
            string s2 = d.ToString("F");
            // Vil gjøre om D til string

            // Fra float/double/string/bool til int
            float f = 12.12f;
            int i = Convert.ToInt32(f);
            // til Float
            float f2 = Convert.ToSingle(i);
            // til double
            double d2 = Convert.ToDouble(s2);

        }
    }
}
