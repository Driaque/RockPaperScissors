using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissor.Models
{
    public class Player
    {
        public string Choice { get; set; }
        public int Score { get; set; }

        //play
        public void play()
        {
            //Prompt for Player's choice
            Console.WriteLine("Type (r) - to play Rock, \t (p) - to play Paper, \t (s) - to play Scissors");
            string playerOption = Console.ReadLine();
            switch (playerOption)
            {
                case "r":
                    this.Choice = "Rock";
                    Console.WriteLine($"You played {this.Choice}");
                    break;
                case "p":
                    this.Choice = "Paper";
                    Console.WriteLine($"You played {this.Choice}");
                    break;
                case "s":
                    this.Choice = "Scissors";
                    Console.WriteLine($"You played {this.Choice}");
                    break;

                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
        }
    }
}