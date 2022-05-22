using System;
using System.Collections.Generic;

namespace MaoriQuiz
{
    class Quiz
    {
        static void Main(string[] args)
        {
            Menu();
            BasicLevel();
            MediumLevel();
            ExtremeLevel();

            static void Menu()
            {
                Console.WriteLine("========================================================");
                Console.WriteLine("Kia Ora And Welcome To My Te Reo Maori Quiz.\nThere Will Be 30 Questions In This Quiz.\n10 Questions Per Level." +
                "\n========================================================\n\nPress Any Key To Start! Or Press E To Exit");
                if (Console.ReadLine().ToLower() == "e")
                {
                    Console.WriteLine("GoodBye!");
                    Environment.Exit(0);
                }
                Console.WriteLine("========================================================");
                Console.WriteLine("PLEASE SELECT A LEVEL:\n\nENTER 1 FOR BASIC LEVEL.\n\nENTER 2 FOR MEDIUM LEVEL.\n\nENTER 3 FOR EXTREME LEVEL.\n");
                Console.WriteLine("========================================================");
                string chooseLevel = Console.ReadLine();
                switch (chooseLevel)
                {
                    case "1":
                        Console.WriteLine("You Have Selected Basic Level!\nPress Enter To Continue:");
                        Console.Clear();
                        BasicLevel();
                        break;
                    case "2":
                        Console.WriteLine("You Have Selected Medium Level!\nPress Enter To Continue: ");
                        Console.Clear();
                        MediumLevel();
                        break;
                    case "3":
                        Console.WriteLine("You Have Selected Extreme Level!\nPress Enter To Continue: ");
                        Console.Clear();
                        ExtremeLevel();
                        break;
                    default:
                        Console.WriteLine("PLEASE ENTER A LEVEL: ");
                        Console.WriteLine("\n");
                        Menu();
                        break;
                }
            }

            static void BasicLevel()
            {
                int score;
                int question = 0;
                int questionNum = 0;
                do
                {
                    string[] questions = { "Question 1:\nWhat is Ocean in Te Reo Maori:", "Question 2:\nWhat is Mother in Te Reo Maori:", "Question 3:\nWhat is Children in Te Reo Maori:", "Question 4:\nWhat is Good Morning in Te Reo Maori:", "Question 5:\nWhat is School in Te Reo Maori:" };
                    Console.WriteLine($"{questionNum}: {questions[question]}\n{question} "); // Asks user the question
                    Console.Beep(700, 800);
                }
                while (question > 7);
                {

                }

            }

            static void MediumLevel()
            {

            }

            static void ExtremeLevel()
            {

            }

        }
    }
}