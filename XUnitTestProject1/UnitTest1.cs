using System;
using System.IO;
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

        [Fact]
        public void FileCanBeUpdated()
        {
            string path = "../../../WordBank.txt";

            Assert.True(Program.AddWordToBank("newWord", path));
        }

        [Fact]
        public void FileCanBeDeleted()
        {
            string path = "../../../WordBank.txt";
            Program.DeleteWordBankFile(path);
            Assert.False(File.Exists(path));
        }

        [Fact]
        public void WordCanBeAdded()
        {
            //arrange
            string path = "../../../WordBank.txt";
            Program.CreateWordBankFile(path);
            Program.AddWordToBank("newWord", path);
            string[] words = File.ReadAllLines(path);

            //assert
            Assert.Equal("NEWWORD", words[words.Length-1]);
        }

        [Fact]
        public void CanReadAllWordsFromFile()
        {
            //arrange
            string path = "../../../WordBank.txt";
            Program.CreateWordBankFile(path);
            string[] words = File.ReadAllLines(path);

            //assert
            Assert.Equal(words, Program.ViewWordBank(path));
        }

        [Fact]
        public void CheckLettersAreDetected()
        {
            //arrange
            string testInput = "SODA";
            string[] letters = new string[] { "A", "B", "C", "D" };
            string[] testResult = new string[] { "_", "_", "D", "A" };

            //assert
            Assert.Equal(testResult, Program.UpdateWordWithGuesses(testInput, letters));
        }
    }
}
