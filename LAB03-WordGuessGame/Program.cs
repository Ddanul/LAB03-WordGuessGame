using System;

namespace LAB03_WordGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Your Own Personal Word Guess Game!");
            Controller();
        }

        static void Controller()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("What would you like to do? ");
                Console.WriteLine("[0] Home; [1] View Word Bank; [2] Add Word; [3] Remove Word; [4] Play Game [5] Exit");
                int option = Convert.ToInt32(Console.ReadLine());
            
                switch (option)
                {
                    case 0:
                        Controller();
                        continue;
                    case 1:
                        ViewWordBank();
                        continue;
                    case 2:
                        Console.WriteLine("Enter New Word: ");
                        string newWord = Console.ReadLine();
                        AddWordToBank(newWord);
                        continue;
                    case 3:
                        Console.WriteLine("Enter Word To Be Removed: ");
                        string removeWord = Console.ReadLine();
                        RemoveWordFromBank(removeWord);
                        continue;
                    case 4:
                        PlayGame();
                        continue;
                    case 5:
                        exit = true;
                        continue;
                    default:
                        Console.WriteLine("Not An Option");
                        continue;
                }
            }
        }

        /// <summary>
        /// Appends new word into txt file
        /// </summary>
        /// <param name="newWord">Word to be added to word bank</param>
        static void AddWordToBank(string newWord)
        {
            Console.WriteLine("Added Word To Bank");
        }


        /// <summary>
        /// Reads and Displays text from file
        /// </summary>
        static void ViewWordBank()
        {
            Console.WriteLine("This is the Word Bank");
        }

        /// <summary>
        /// Removes Word from txt file
        /// </summary>
        /// <param name="removeWord">word to be removed from txt file</param>
        static void RemoveWordFromBank(string removeWord)
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

    }
}
