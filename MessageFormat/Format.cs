using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MessageFormat
{
    class Format
    {
        public string RegexName = "^[A-Z]{1}[a-z]{2,}$";
        public string RegexFullName = "^[A-Z]{1}[a-z]{3,}$";
        public string RegexPhNum = "^[6-9]{1}[0-9]{9}$";
        public bool ValidateName(string name)
        {
            return Regex.IsMatch(name, RegexName);
        }
        public bool ValidateFname(string fullname)
        {
            return Regex.IsMatch(fullname, RegexFullName);
        }

        public bool ValidateNum(string PhNum)
        {
            return Regex.IsMatch(PhNum, RegexPhNum);
        }

    }
}
