using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissor.Models
{
    public class Game
    {
        public Player player { get; set; }
        public Computer computer { get; set; }
        public string CurrentWinner { get; set; }
        public string OverallWinner { get; set; }
        public int NumberOfRounds { get; set; }
        public bool replay { get; set; }

        //Methods
        //Initialize Actors
        public void init()
        {
            try
            {
                player = new Player();
                computer = new Computer();
                Console.WriteLine(":::: Rock Paper Scissors Game ::::");

                //Get Mode
                chooseMode();

                //Select Computer Type
                chooseOpponent();

                //Start Match
                startMatch(player, computer, NumberOfRounds);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error Has occured! {ex.Message}");
                throw;
            }
            
        }
        //startMatch() 
        public void startMatch(Player player, Computer computer, int rounds)
        {
            try
            {
                Console.WriteLine($"You are playing {computer.Type.ToString()} Computer");
                Console.WriteLine($"Player vs {computer.Type.ToString()}");
                int count = 0;
                while (count < rounds)
                {
                    Console.WriteLine($"Select an option:");
                    //Check Computer Type And get Computer choice
                    if (computer.Type.ToString() == "Random")
                    {
                        computer.Choice = computer.playRandom();
                    }
                    else if (computer.Type.ToString() == "Tactical")
                    {
                        if (string.IsNullOrEmpty(computer.LastChoice))
                        {
                            computer.Choice = computer.playRandom(); // if there's no last play, play random
                            computer.LastChoice = computer.Choice; //Set last choice
                        }
                        else
                        {
                            computer.playNextBest(computer.LastChoice);
                            computer.Choice = computer.NextBest;
                            computer.LastChoice = computer.Choice; //Set last choice
                        }
                    }
                    //Get player's choice
                    player.play();

                    //Determine Winner
                    determineWinner(player, computer);
                    count++;
                }
                displayWinner(player, computer);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error Has occured! {ex.Message}");
                throw;
            }
            
        }
        public void stopGame()
        {
            Console.WriteLine("Exiting Application...");
            Environment.Exit(-1);
            return;
        }
        public void chooseMode()
        {
            try
            {
                //Get Mode
                Console.WriteLine("What mode would you like to play?");
                Console.WriteLine("Type (a) - for Best of 3 , \t (b) for Best of 5  and \t (x) for Exit");
                string modeOption = Console.ReadLine();
                switch (modeOption)
                {
                    case "a":
                        NumberOfRounds = 3;
                        Console.WriteLine("Best Of 3 Selected");
                        break;

                    case "b":
                        NumberOfRounds = 5;
                        Console.WriteLine("Best Of 5 Selected");
                        break;

                    case "x": // Exit game
                        stopGame();
                        break;

                    default:
                        Console.WriteLine("Invalid Option!");
                        NumberOfRounds = 3; //default mode is Best of 3
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error Has occured! {ex.Message}");
                throw;
            }
            
        }
        public void chooseOpponent()
        {
            try
            {
                //Select Computer Type
                Console.WriteLine("What type of Computer would you like to play against?");
                Console.WriteLine("Type (r) - for Random, \t (t) for Tactical and \t (x) for Exit ");
                string typeOption = Console.ReadLine();
                switch (typeOption)
                {
                    case "r":
                        computer.Type = (ComputerType)0;
                        Console.WriteLine("Random has been Selected");
                        break;

                    case "t":
                        computer.Type = (ComputerType)1;
                        Console.WriteLine("Tactical has been Selected");
                        break;
                    case "x": // Exit game 
                        stopGame();
                        break;

                    default:
                        Console.WriteLine("Invalid Option!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error Has occured! {ex.Message}");
                throw;
            }
            
        }
        public void determineWinner(Player player, Computer computer)
        {
            try
            {
                if (player != null && computer != null)
                {
                    //Get Computer's Choice
                    Console.WriteLine($"Computer Played {computer.Choice}!");

                    if (player.Choice == computer.Choice)
                    {
                        Console.WriteLine($"It's a Tie!");
                    }
                    else if (player.Choice == "Rock")
                    {
                        if (computer.Choice == "Paper")
                        {
                            Console.WriteLine($"You Lose! {computer.Choice} covers {player.Choice}");
                            computer.Score = computer.Score + 1;
                        }
                        else
                        {
                            Console.WriteLine($"You Win! {player.Choice} smashes {computer.Choice}");
                            player.Score = player.Score + 1;
                        }
                    }
                    else if (player.Choice == "Paper")
                    {
                        if (computer.Choice == "Scissors")
                        {
                            Console.WriteLine($"You Lose! {computer.Choice} cut {player.Choice}");
                            computer.Score = computer.Score + 1;
                        }
                        else
                        {
                            Console.WriteLine($"You Win! {player.Choice} covers {computer.Choice}");
                            player.Score = player.Score + 1;
                        }
                    }
                    else if (player.Choice == "Scissors")
                    {
                        if (computer.Choice == "Rock")
                        {
                            Console.WriteLine($"You Lose! {computer.Choice} smashes {player.Choice}");
                            computer.Score = computer.Score + 1;
                        }
                        else
                        {
                            Console.WriteLine($"You Win! {player.Choice} cut {computer.Choice}");
                            player.Score = player.Score + 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid Play! ");
                    }
                }
                else
                {
                    Console.WriteLine($"An Error has occured! ");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error Has occured! {ex.Message}");
                throw;
            }
            

        }
        //displayWinner()
        public void displayWinner(Player player, Computer computer)
        {
            try
            {
                if (player != null && computer != null)
                {
                    if (player.Score > computer.Score)
                    {
                        Console.WriteLine($"Player Wins the Game!");
                    }
                    else if (player.Score == computer.Score)
                    {
                        Console.WriteLine($"It's a Draw !");
                    }
                    else
                    {
                        Console.WriteLine($"Computer Wins the Game! ");
                    }
                }
                else
                {
                    Console.WriteLine($"An Error has occured! ");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error Has occured! {ex.Message}");
                throw;
            }
            
        }

        public bool promptReplay()
        {
            try
            {
                Console.WriteLine("Would you Like to Play again?");
                Console.WriteLine("Type (y) - for Yes \t (n) for No ");
                string replayOption = Console.ReadLine();
                switch (replayOption)
                {
                    case "y":
                        replay = true;
                        return replay;
                    case "n":
                        replay = false;
                        Console.WriteLine("Game Over");
                        return replay;
                    case "x": // Exit game
                        stopGame();
                        return replay =false;
                    default:
                        Console.WriteLine("Invalid Option !");
                        return replay;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error Has occured! {ex.Message}");
                throw;
            }
        }

        public enum GameRules 
        {
            RockWinsScissors,
            ScissorsWinsPaper,
            PaperWinsRock
        }

        public enum Moves
        {
            Rock,
            Scissors,
            Paper,
        }

        public enum Modes
        {
            BestOf3,
            BestOf5,
        }

    }
}