# RockPaperScissors
A simple console game that runs the Rock Paper Scissors Engine. Player gets to play random computer or tactical computer.

# Design Approach
- Domain Driven Design 

# Actors
- Game
- Player
- Computer

# Models

# Player
+ Choice
+ Score
_______________
+ play()

# Computer
+ Type
+ Choice
+ LastChoice
+ NextBestChoice
+ Score
________________
+ playRandom()
+ playNextBest()

# Game
+ Player
+ Computer
+ NumberOfRounds
+ Mode
+ OverallWinner
+ replay
________________
+ init()
+ chooseMode()
+ chooseOpponent()
+ startMatch()
+ stopGame()
+ determineWinner()
+ displayWinner()
+ promptReplay()

# How to Run Application
There are two ways to run the application;
1. Locate the executable file in \RockPaperScissorsConsole\bin\Debug and open it to play game
2. Load the Project File in Visual Studio and Start Project.

## Future Extensions
- Text formatting for console app
- Expose methods as API for Web Developemnt
- Create Web/WPF UI
