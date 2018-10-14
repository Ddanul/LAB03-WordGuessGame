using System;
using Xunit;
using LAB03_WordGuessGame;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestFileCreated()
        {
            string path = "../../../WordBank.txt";

            Assert.True(Program.CreateWordBankFile(path));
        }
    }
}
