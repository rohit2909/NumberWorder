using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWorder.OutPut
{
    public class NumberOutput:IOutPut
    {
        public string Apply(string input)
        {
            StringBuilder output = new StringBuilder();
            foreach(char c in input)
            {
                output.Append(Getstring(c));
            }

            Console.WriteLine(string.Format("This is output : {0}", output.ToString()));
            Console.WriteLine("Enter 1 to enter new input or any other key to exit");
            return Console.ReadLine();
        }

        private static string Getstring(char c)
        {
            string output = string.Empty;
            switch(c)
            {
                case '1':
                    output = "One";
                    break;
                case '2':
                    output = "Two";
                    break;
                case '3':
                    output = "Three";
                    break;
                case '4':
                    output = "Four";
                    break;
                case '5':
                    output = "Five";
                    break;
                case '6':
                    output = "Six";
                    break;
                case '7':
                    output = "Seven";
                    break;
                case '8':
                    output = "Eight";
                    break;
                case '9':
                    output = "Nine";
                    break;
                case '0':
                output = "Zero";
                break;
            }
            return output;
        }
    }
}
