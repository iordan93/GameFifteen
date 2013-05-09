GameFifteen
===========

High-Quality Code Construction – Game “Fifteen”
-----------------------------------------------

Your task is to write an interactive console-based implementation of the game “Fifteen” in which the player tries to arrange the numbers from 1 to 15 sequentially in a square matrix of size 4 x 4. The game starts from a randomly shuffled 15 numbers in a matrix (4 x 4) and a random cell left empty (see the figure below). At each turn the player enters a number from the matrix, neighbor to the empty cell that should move over it. The game finishes when the numbers are arranged sequentially (see the figure). When the game is finished, a new game automatically starts.

When the starting position is randomly generated at the program start, your algorithm should ensure that the target position is reachable from the starting position with a sequence of legal moves.
 
The player can request starting a new game by entering the command 'restart'.

Your program should implement a local top scoreboard which keeps the best results and the names of their authors. Initially, at the program start, the scoreboard is empty. It keeps the top 5 results sorted in ascending order by the number of moves. When a game is finished by popping all balloons, the player’s result can enter in the top scoreboard if his or her number of moves is less than some of the other achievements staying in the top scoreboard. When the player’s result enters the scoreboard, the player should enter his or her name or nickname.

The player can request printing the top scoreboard during the game by entering the command 'top'.

The player can request stopping the game and exiting from the program the command 'exit'.



