using FileData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData.Core
{
    public class ProcessCommandArgument : IProcessCommandArgument
    {
        public string GetInformation(string command, string filePath)
        {
            var fileDetails = new FileDetails();
            switch (command)
            {
                case "-v":
                case "--v":
                case "/v":
                case "--version":
                    return fileDetails.Version(filePath);
                case "-s":
                case "--s":
                case "/s":
                case "--size":
                    return fileDetails.Size(filePath).ToString();
            }

            return null;
        }

        public bool VerifyArgument(string[] arguments, out string errorInfo)
        {
            errorInfo = string.Empty;
            if (arguments.Length == 2 && !string.IsNullOrEmpty(arguments[0]) && !string.IsNullOrEmpty(arguments[1]))
            {
                return true;
            }
            else
            {
                errorInfo = "Command Arguments are incorrect";
            }
            return false;
        }
    }
}
