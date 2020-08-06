# RockPaperScissors
A simple console game that runs the Rock Paper Scissors Engine. Player gets to play random computer or tactical computer.

##Actors
- Game
- Player
- Computer

# Models

# Player
+ Name
+ Choice
+ Score

+ play()

# Computer
+ Type
+ Choice
+ LastChoice
+ NextBestChoice
+ Score

+ playRandom()
+ playNextBest()

# Game
+ Player
+ Computer
+ NumberOfRounds
+ Mode
+ OverallWinner
+ replay

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
