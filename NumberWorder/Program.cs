using NumberWorder.Helper;
using NumberWorder.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWorder
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                helper.start();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error in processing your request.Please contact your administrator.");
                //Log Exception
                Console.WriteLine("Enter any key to exit");
                Console.ReadLine();
            }
        }
    }
}
