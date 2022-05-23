using System;
using System.Collections.Generic;

namespace TeReoMaoriQuizProject
{
    class MaoriQuiz
    {
        static void Main(string[] args)
        {
            Menu();
            MediumLevel();
            ExtremeLevel();
            // Psudo Code
            /* This program is a 30 Question Quiz On Te Reo Maori. 
             Use System, Class = MainClass, Public static void Main() = Can Be Called Without Object. 
             Add And Declare Int Variables For Option, Score And (Question = Answer).
             Add An Introduction Message. 
             10 Questions On Basic Level And Add Basic Level Message. 
             Add A While Loop To Each Question So The User Is Only Allowed To Type (1, 2, 3, 4). 
             Have If Statement For Correct Answer And Add 1 To The Score, Else Display Incorrect Answer If The User Dosen't Input The Right Answer To The Question. 
             10 Questions On Medium Level And Add Medium Level Message.
             Add A While Loop To Each Question So The User Is Only Allowed To Type (1, 2, 3, 4). 
             Have If Statement For Correct Answer And Add 1 To The Score, Else Display Incorrect Answer If The User Dosen't Input The Right Answer To The Question.
             10 Questions On Extreme Level And Add Extreme Level Message.
             Add A While Loop To Each Question So The User Is Only Allowed To Type (1, 2, 3, 4). 
             Have If Statement For Correct Answer And Add 1 To The Score, Else Display Incorrect Answer If The User Dosen't Input The Right Answer To The Question.
             Tally Up All The Correct Answers Out Of 20.
             Display End Message
            */

            // Feedback 
            // Ashin: Add music/sound for incorrect answer.
            // Thisara: Give second chance for 5 times and show what answers was wrong.
            // Gilbert: The overall code is to my knowledge unbreakable and entering non answers leaves you with a message saying to reenter a number - between  1 - 4.I think it would be nice to only give the extreme level questions to anyone who has atleast
            // scored 50 percent this would make it like levels in a game where if you fail level 1 you would not go onto level two. Overall the code is effective but plain and does not have a risk factor or different types of questions that would make the
            // quiz more engaging instead of the same type of questions over and over, These questions could be tue or false questions or any other type of questions. That is my personal opinion.
            // Teacher: There is no loop implemented. Give the option to the user to continue with the program. Use any looping concept. 
            // Implement at least one method. You can create a method to the main menu. You might want to add some more questions and create different levels. Give options to the user to select the levels.Each level can be called by a method.  
            // Perform the testing and include this in your AS91884 standard write-up. 
            // Try and add some spacing between questions. 
            // Try and implement a method to calculate the scores with a return type. 


            // Add Array For Each Level To Replace Variables Into Shorter Length

            // Declare Variables

            static void Menu()
            {
                // Introduction
                Console.WriteLine("========================================================");
                Console.WriteLine("Kia Ora And Welcome To My Te Reo Maori Quiz.\n" +
                "There Will Be 30 Questions In This Quiz.\n10 Questions Per Level." +
                "\n========================================================\n" +
                "\nEnter Any Key To Continue! Or Enter E To Exit!\n\n========================================================");
                if (Console.ReadLine().ToLower() == "e")
                {
                    Console.WriteLine("\nGoodBye");
                    Environment.Exit(0);
                }
                Console.WriteLine("========================================================\n" +
                "ENTER 1 FOR BASIC LEVEL.\n\nENTER 2 FOR MEDIUM LEVEL." +
                "\n\nENTER 3 FOR EXTREME LEVEL.");
                Console.WriteLine("========================================================\n");
                string chooseLevel;
                chooseLevel = Console.ReadLine();
                switch (chooseLevel)
                {
                    case "1":
                        Console.Clear();
                        BasicLevel();
                        break;
                    case "2":
                        Console.Clear();
                        MediumLevel();
                        break;
                    case "3":
                        Console.Clear();
                        ExtremeLevel();
                        break;
                    default:
                        Console.WriteLine("PLEASE ENTER A VALID OPTION: ");
                        Menu();
                        break;
                }

            }

            static void BasicLevel()
            {
                int score = 0;
                int question = 0;
                int userInput;

                string[] basicLevelQuestions = new string[5] { "Question 1: What is Ocean in Te Reo Maori:", "\nQuestion 2: What is Mother in Te Reo Maori:", "\nQuestion 3: What is Children in Te Reo Maori:", "\nQuestion 4: What is Good Morning in Te Reo Maori:", "\nQuestion 5: What is School in Te Reo Maori:" };
                string[] options = new string[5] { "\n1) Ocean\n2) Moana\n3) Awa\n4) River", "\n1) Whaea\n2) Whanau\n3) Tamaraki\n4) Mama", "\n1) Tamaraki \n2) Children \n3) Tena Koe \n4) Ka Kite", "n1) Ahiahi Pai \n2) Kia Ora \n3) Morena \n4) Ra Pai", "\n1) Whare\n2) Kura\n3) Hapu\n4) Tane" };
                int[] basicLevelAnswers = new int[6] { 2, 1, 4, 1, 3, 2 };

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("You Know Are Answering Basic Level Questions, Good Luck.\nPRESS ENTER TO CONTINUE: ");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ReadLine();
                Console.WriteLine($"{basicLevelQuestions[question]} {options[question]}");
                while (!int.TryParse(Console.ReadLine(), out userInput) || userInput <= 0 || userInput >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
                {
                    Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
                }
                if (userInput == basicLevelAnswers[question])
                {
                    Console.WriteLine("Correct Answer!");
                    score++;
                    question++;
                }
                else if (userInput != basicLevelAnswers[question])
                {
                    Console.WriteLine("Incorrect Answer!");
                    question++;
                }

            }

            static void MediumLevel()
                {
                    string[] questions = { "Question 1:\nWhat is Guardian in Te Reo Maori:, Question 2:\nWhat is Prayer in Te Reo Maori:, Question 3:\nWhat is Sovereighty in Te Reo Maori:", "Question 4:\nWhat is Crying in Te Reo Maori:, Question 5:\nWhat is Ancestry in Te Reo Maori:", "Question 6:\nWhat is Embarrassed in Te Reo Maori:, Question 7:\nWhat is Treasure in Te Reo Maori:" };
                    string[] options = { "\n1) Tane\n2) Kaitiaki\n3) Taniwha\n4) Ruru, \n1) Karakia\n2) Rongoa\n3) Raupo\n4) Raupatu, n1) Rangatahi\n2) Rangatira\n3) Rahui\n4) Rangatiratanga", "\n1) Porohe\n2) Tangihanga\n3) Piharau\n4) Patiki", "\n1) Panui\n2) Pa Tuna\n3) Whakapapa\n4) Ngawha", "\n1) Whakama\n2) Wairua\n3) Korowai\n4) Korimako, \n1) Korero\n2) Kokopu\n3) Tangi\n4) Taonga" };
                    string[] answers = { "2, 1, 4, 2, 3, 1, 4 " };

                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("You Now Are Answering Medium Level Questions, Good Luck.\nPRESS ENTER TO CONTINUE: ");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                }

                static void ExtremeLevel()
                {
                    string[] questions = { "" };
                    string[] options = { "" };
                    string[] answers = { "" };

                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("You Now Are Answering Extreme Level Questions, Good Luck.\nPRESS ENTER TO CONTINUE: ");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.ReadLine();

                }

        }
    }
}