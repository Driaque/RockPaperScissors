using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static RockPaperScissor.Models.Game;

namespace RockPaperScissor.Models
{
    public class Computer
    {
        public ComputerType Type { get; set; }
        public int Score { get; set; }
        public string Choice { get; set; }
        public string LastChoice { get; set; }
        public bool winLastGame { get; set; }
        public string NextBest { get; set; }

        //Methods
        //playRandom()
        public string playRandom()
        {
            //Random play
            Random random = new Random();
            int maxChoice = Enum.GetValues(typeof(Moves)).Length;
            int choiceValue = random.Next(0, (maxChoice - 1));
            Moves moveChoice = (Moves)choiceValue;
            string choice = moveChoice.ToString();
            return choice;
        }

        //playNextBest()
        public void playNextBest(string lastChoice)
        {
            try
            {
                switch (lastChoice)
                {
                    case "Rock":
                        NextBest = "Paper";
                        Console.WriteLine($"Next best choice is {NextBest}");
                        break;

                    case "Paper":
                        NextBest = "Scissors";
                        Console.WriteLine($"Next best choice is {NextBest}");
                        break;

                    case "Scissors":
                        NextBest = "Rock";
                        Console.WriteLine($"Next best choice is {NextBest}");
                        break;

                    default:
                        Console.WriteLine("Invalid Option!");
                        NextBest = playRandom();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error Has occured! {ex.Message}");
                throw;
            }
        }
    }

    public enum ComputerType
    {
        Random,
        Tactical
    }
}