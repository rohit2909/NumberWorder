using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NumberWorder.Validation
{
    public class DataValidation:IValidation
    {
        public string isValid(string input)
        {
            string pattern = "^[0-9]{1,20}$";
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            if (rgx.IsMatch(input))
            {
                return string.Empty;
            }
            else
            {
                return "Please enter the number in Correct Format";
            }
        }
    }
}
