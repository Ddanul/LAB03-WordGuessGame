using System;
using System.IO;

namespace LAB03_WordGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Your Own Personal Word Guess Game!");
            string path = "../../../WordBank.txt";

            CreateWordBankFile(path);
            Controller();

        }

        static void Controller()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("What would you like to do? ");
                Console.WriteLine("[0] Home; [1] View Word Bank; [2] Add Word; [3] Remove Word; [4] Play Game; [5] Admin; [6] Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                string path = "../../../WordBank.txt";

                switch (option)
                {
                    case 0:
                        Controller();
                        continue;
                    case 1:
                        ViewWordBank(path);
                        continue;
                    case 2:
                        Console.WriteLine("Enter New Word: ");
                        string newWord = Console.ReadLine();
                        AddWordToBank(newWord, path);
                        continue;
                    case 3:
                        Console.WriteLine("Enter Word To Be Removed: ");
                        string removeWord = Console.ReadLine();
                        RemoveWordFromBank(removeWord, path);
                        continue;
                    case 4:
                        PlayGame();
                        continue;
                    case 5:
                        AdminController();
                        continue;
                    case 6:
                        exit = true;
                        continue;
                    default:
                        Console.WriteLine("Not An Option");
                        continue;
                }
            }
        }

        static void AdminController()
        {
            Console.WriteLine("**ADMIN DASHBOARD***");
            Console.WriteLine("Delete File? [Y/N]");
            string option = Console.ReadLine();
            if(option.ToUpper() == "Y")
            {
                string path = "../../../WordBank.txt";
                DeleteWordBankFile(path);
            }
        }

        /// <summary>
        /// Method creates new word bank text file with 4 default words.
        /// </summary>
        static void CreateWordBankFile(string path)
        {
            try
            {
                string[] defaultWords= new string[4];
                defaultWords[0] = "Cupcake";
                defaultWords[1] = "Kitty";
                defaultWords[2] = "Curls";
                defaultWords[3] = "Testing";

                File.WriteAllLines(path, defaultWords);
            }
            catch(Exception)
            {
                Console.WriteLine("Something Bad Happened.");
            }
        }

        /// <summary>
        /// Appends new word into txt file
        /// </summary>
        /// <param name="newWord">Word to be added to word bank</param>
        static void AddWordToBank(string newWord, string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                try
                { 
                    sw.WriteLine(newWord);
                    Console.WriteLine("Added Word To Bank");
                }
                catch (Exception)
                {
                    Console.WriteLine("Your Word encountered an error!");
                }
            }
            
        }


        /// <summary>
        /// Reads and Displays text from file
        /// </summary>
        static void ViewWordBank(string path)
        {
            try
            {
                string[] words = File.ReadAllLines(path);
                Console.WriteLine("This is the Word Bank");
                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Removes Word from txt file
        /// </summary>
        /// <param name="removeWord">word to be removed from txt file</param>
        static void RemoveWordFromBank(string removeWord, string path)
        {

            Console.WriteLine("Word Removed From Bank");
        }

        /// <summary>
        /// Initiates games
        /// </summary>
        static void PlayGame()
        {
            Console.WriteLine("Game is starting");
        }

        /// <summary>
        /// Method deletes word bank text file.
        /// </summary>
        static void DeleteWordBankFile(string path)
        {
            File.Delete(path);
        }

    }
}
