using System;

namespace Open_Lab_03._05
{
    public class Comparator
    {
        public bool MatchCaseInsensitive(string str1, string str2)
        {
            if (!String.Equals(str1, str2, StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
