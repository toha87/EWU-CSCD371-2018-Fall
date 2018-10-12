using System;

namespace PaperRockScissors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool PlayAgain = true;

            do
                {
                        var winner = GameAction();
                        WhoWon(winner);
                        bool PlayAgainAnswer = PlayAgainMethod();
                        PlayAgain = PlayAgainAnswer;

                } while (PlayAgain == true);
        }

        public static string GetUserInput()
        {
            Console.WriteLine("Do you choose rock, paper or scissors");
            string userChoice = Console.ReadLine();

            if (userChoice == "rock")
                return userChoice;
            else if (userChoice == "paper")
                return userChoice;
            else if (userChoice == "scissors")
                return userChoice;
            else
                Console.WriteLine("You must choose rock, paper or scissors!");

            return userChoice;
        }

        public static int GetComputerInput()
        {
            Random r = new Random();
            int computerChoice = r.Next(1, 4);

            return computerChoice;
        }

        public static Tuple<string, int> GameAction()
        {
            int PlayerScore = 100, ComputerScore = 100;

            while (PlayerScore > 0 && ComputerScore > 0)
            {
                String userChoice = GetUserInput();
                int computerChoice = GetComputerInput();

                if (computerChoice == 1)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("It is a tie ");
                        Console.WriteLine($"Player {PlayerScore}, Computer {ComputerScore}");
                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("It is a tie ");
                        Console.WriteLine($"Player {PlayerScore}, Computer {ComputerScore}");
                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("It is a tie ");
                        Console.WriteLine($"Player {PlayerScore}, Computer {ComputerScore}");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper or scissors!");
                    }

                }

                else if (computerChoice == 2)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("Sorry you lose, paper beat rock");
                        PlayerScore = PlayerScore - 10;
                        Console.WriteLine($"Player {PlayerScore}, Computer {ComputerScore}");

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("Sorry you lose, scissors beat paper ");
                        PlayerScore = PlayerScore - 15;
                        Console.WriteLine($"Player {PlayerScore}, Computer {ComputerScore}");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("Sorry you lose, rock beats scissors");
                        PlayerScore = PlayerScore - 20;
                        Console.WriteLine($"Player {PlayerScore}, Computer {ComputerScore}");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper or scissors!");
                    }
                }
                else if (computerChoice == 3)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("You win, rock beats scissors");
                        ComputerScore = ComputerScore - 20;
                        Console.WriteLine($"Player {PlayerScore}, Computer {ComputerScore}");

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("You win, paper beats rock");
                        ComputerScore = ComputerScore - 10;
                        Console.WriteLine($"Player {PlayerScore}, Computer {ComputerScore}");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("You win, scissors beat paper");
                        ComputerScore = ComputerScore - 15;
                        Console.WriteLine($"Player {PlayerScore}, Computer {ComputerScore}");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper or scissors!");
                    }

                }
            }

            if (PlayerScore > 0)
                return Tuple.Create("Player", PlayerScore);
            else
                return Tuple.Create("Computer", ComputerScore);
        }

        public static void WhoWon(Tuple<string, int> winner)
        {
                Console.WriteLine("");
                Console.WriteLine($"Congrats! {winner.Item1} won with score {winner.Item2}!");
        }

        public static bool PlayAgainMethod()
        {
            bool PlayAgain = true;
            Console.WriteLine("");
            Console.WriteLine("Do you want to try again? Y/N");
            string res = Console.ReadLine();
            if (res == "Y" || res == "y")
            {
                PlayAgain = true;
            }
            else
            {
                PlayAgain = false;
                Environment.Exit(0);
            }

            return PlayAgain;
        }
    }
}
