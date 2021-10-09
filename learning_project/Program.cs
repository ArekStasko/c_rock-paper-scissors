using System;

namespace learning_project
{
    class Program
    {
        static void Main(string[] args)
        {

            //This is my first code in C# i don't know any syntax or rules thats why this code looks messy 


            string[] chooseTypes = { "rock", "paper", "scissors" };

            Console.WriteLine("Hello in my --- ROCK PAPER SCISSORS --- game !");

            ///////////////////////////////////////////////////////////////////////////////////
            ///CHOOSING ROUND COUNT
            Console.WriteLine("Choose how many rounds do you want to play: ");
            int rounds = Convert.ToInt32(Console.ReadLine());

            ///////////////////////////////////////////////////////////////////////////////////
            ///USERS POINTS COUNTERS
            int playerFirstCount = 0;
            int playerSecondCount = 0;


            while (rounds != 0)
            {

                ///////////////////////////////////////////////////////////////////////////////////
                ///GET DATA AND VALIDATION

                Console.WriteLine("Player 1 - Choose from 'rock paper scissors' :");
                string playerFirstChoose = Console.ReadLine();

                while (Array.IndexOf(chooseTypes, playerFirstChoose) == -1)
                {
                    Console.WriteLine("Please repeat the correct value from options :");
                    playerFirstChoose = Console.ReadLine();
                }

                Console.WriteLine("Player 2 - Choose from 'rock paper scissors' :");
                string playerSecondChoose = Console.ReadLine();


                while (Array.IndexOf(chooseTypes, playerSecondChoose) == -1)
                {
                    Console.WriteLine("Please repeat the correct value from options :");
                    playerSecondChoose = Console.ReadLine();
                }

                ///////////////////////////////////////////////////////////////////////////////
                //// LOGIC

                if (playerFirstChoose == playerSecondChoose)
                {
                    Console.WriteLine("Draw !");
                }
                else if (playerFirstChoose == "rock" && playerSecondChoose == "scissors")
                {
                    Console.WriteLine("Player 1 Wins !");
                    playerFirstCount++;
                }
                else if (playerFirstChoose == "paper" && playerSecondChoose == "rock")
                {
                    Console.WriteLine("Player 1 Wins !");
                    playerFirstCount++;
                }
                else if (playerFirstChoose == "scissors" && playerSecondChoose == "paper")
                {
                    Console.WriteLine("Player 1 Wins !");
                    playerFirstCount++;
                }
                else
                {
                    Console.WriteLine("Player 2 Wins !");
                    playerSecondCount++;
                }
                rounds--;
            }

            ///////////////////////////////////////////////////////////////
            ///SCORE 
            if (playerFirstCount > playerSecondCount)
            {
                Console.WriteLine("Player 1 Win !");
            }
            else if (playerFirstCount == playerSecondCount)
            {
                Console.WriteLine("Draw !");
            }
            else
            {
                Console.WriteLine("Player 2 Win !");
            }
        }
    }
}
