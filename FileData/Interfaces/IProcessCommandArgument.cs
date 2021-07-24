namespace FileData.Interfaces
{
    interface IProcessCommandArgument
    {
        bool VerifyArgument(string[] arguments, out string errorInfo);
        string GetInformation(string command, string filePath);
    }
}
