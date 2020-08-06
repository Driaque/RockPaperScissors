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
+ Name
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


## Future Extensions
- Text formatting for console app
- Expose methods as API for Web Developemnt
- Create Web/WPF UI
