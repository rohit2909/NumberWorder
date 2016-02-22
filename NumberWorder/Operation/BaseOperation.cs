using NumberWorder.OutPut;
using NumberWorder.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWorder.Operation
{
    public abstract class BaseOperation
    {
       
        public IOutPut output;
        string error;
        internal void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string input = EnterOperationMessage();
            error = string.Empty;
            error = isValid(input);
            if (error == string.Empty)
            {
                string op = output.Apply(input); 
                if(op =="1")
                {
                    Execute();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input is not in Correct Format");
                Console.ForegroundColor = ConsoleColor.Yellow;               
                Execute();
            }
        }
        
        public abstract string EnterOperationMessage();

        public abstract string isValid(string input);
        

        internal void SetOutPut(IOutPut Output)
        {
            output = Output;
        }
    }
}
