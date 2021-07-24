using FileData.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FileData.Tests
{
    [TestClass]
    public class UnitTest1
    {        
        [TestMethod]
        public void TestFileVersionMethod()
        {
            var processCommandArgument = new ProcessCommandArgument();
            string[] args = new string[] { "-v", "C:/test.txt" };
            var data = processCommandArgument.GetInformation(args[0], args[1]);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void TestFileVersionDoubleMinusVMethod()
        {
            var processCommandArgument = new ProcessCommandArgument();
            string[] args = new string[] { "--v", "C:/test.txt" };
            var data = processCommandArgument.GetInformation(args[0], args[1]);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void TestFileVersionSlashVMethod()
        {
            var processCommandArgument = new ProcessCommandArgument();
            string[] args = new string[] { "/v", "C:/test.txt" };
            var data = processCommandArgument.GetInformation(args[0], args[1]);
            Assert.IsNotNull(data);
        }


        [TestMethod]
        public void TestFileVersionVersionCommandMethod()
        {
            var processCommandArgument = new ProcessCommandArgument();
            string[] args = new string[] { "--version", "C:/test.txt" };
            var data = processCommandArgument.GetInformation(args[0], args[1]);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void TestFileSizeSCommandMethod()
        {
            var processCommandArgument = new ProcessCommandArgument();
            string[] args = new string[] { "-s", "C:/test.txt" };
            var data = processCommandArgument.GetInformation(args[0], args[1]);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void TestFileSizeIncorrectCommandMethod()
        {
            var processCommandArgument = new ProcessCommandArgument();
            string[] args = new string[] { "-ss", "C:/test.txt" };
            var data = processCommandArgument.GetInformation(args[0], args[1]);
            Assert.IsNull(data);
        }
    }
}
