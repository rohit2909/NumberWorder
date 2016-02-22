using NumberWorder.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWorder.Helper
{
    public static class helper
    {
        public static void start()
        {
            Console.WriteLine("*************");
            Console.WriteLine("Please Select the Operation:");
            Console.WriteLine("Enter 1 for Number to Word(default)");
            Console.WriteLine("Enter any other key to exit");
            string input = Console.ReadLine();
            SetOperation(input);

        }

        private static void SetOperation(string input)
        {
            BaseOperation operation;
            switch (input)
            {
                case "1":
                    operation = new NumberOperation();
                    break;
                default:
                    return;
                    
            }
            operation.Execute();
        }
    }
}
