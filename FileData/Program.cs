using FileData.Core;
using FileData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var processCommandArguments = new ProcessCommandArgument();
            var processAhead = processCommandArguments.VerifyArgument(args, out string errorInfo);
            if (processAhead)
            {
                Console.WriteLine(processCommandArguments.GetInformation(args[0], args[1]));
            }
            else
            {
                Console.WriteLine(errorInfo);
            }
            Console.ReadKey();
        }


    }
}
