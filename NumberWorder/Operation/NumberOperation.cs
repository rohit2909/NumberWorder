using NumberWorder.OutPut;
using NumberWorder.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWorder.Operation
{
    public class NumberOperation:BaseOperation
    {
        public NumberOperation()
        {
            output = new NumberOutput();
        }
        public override string isValid(string input)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(new DataValidation().isValid(input));
            return sb.ToString();

        }

        public override string EnterOperationMessage()
        {
            Console.WriteLine("Please use the following instructions for input:-");
            Console.WriteLine("1. Use only Numeric Character i.e 0-9 without spaces.");
            Console.WriteLine("2. Do Not Use only Prefix or Suffix with Numeric Characters.");
            Console.WriteLine("3. The Total Length should not not more then 20.");
            Console.WriteLine("Example of Correct input:- 2239120");
            Console.WriteLine("Example of wrong input:- Abc123");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************");
            Console.WriteLine("Please enter the Input");
            Console.WriteLine("*************");
            return Console.ReadLine();
        }
    }
}
