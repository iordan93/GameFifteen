GameFifteen
===========

High-Quality Code Construction – Game “Fifteen”
-----------------------------------------------

Your task is to write an interactive console-based implementation of the game “Fifteen” in which the player tries to arrange the numbers from 1 to 15 sequentially in a square matrix of size 4 x 4. The game starts from a randomly shuffled 15 numbers in a matrix (4 x 4) and a random cell left empty (see the figure below). At each turn the player enters a number from the matrix, neighbor to the empty cell that should move over it. The game finishes when the numbers are arranged sequentially (see the figure). When the game is finished, a new game automatically starts.

When the starting position is randomly generated at the program start, your algorithm should ensure that the target position is reachable from the starting position with a sequence of legal moves.
 
  ------------  	   ------------       ------------       ------------
 |  5     2  4 | 	  |  1  2  3  4 |    |  1  2  3  4 |    |  1  2  3  4 |
 |  9  1  8 12 |	  |  5  6  7  8 |    |  5  6  7  8 |    |  5  6  7  8 |
 | 13  7 10  3 | ->..-> |  9 10    12 | -> |  9 10 11 12 | -> |  9 10 11 12 |
 | 14  6 11 15 | 	  | 13 14 11 15 |    | 13 14    15 |    | 13 14 15    |
  ------------  	   ------------       ------------       ------------




The player can request starting a new game by entering the command 'restart'.

Your program should implement a local top scoreboard which keeps the best results and the names of their authors. Initially, at the program start, the scoreboard is empty. It keeps the top 5 results sorted in ascending order by the number of moves. When a game is finished by popping all balloons, the player’s result can enter in the top scoreboard if his or her number of moves is less than some of the other achievements staying in the top scoreboard. When the player’s result enters the scoreboard, the player should enter his or her name or nickname.

The player can request printing the top scoreboard during the game by entering the command 'top'.

The player can request stopping the game and exiting from the program the command 'exit'.



Example Game Session
---------------------

The player’s input is shown in italic:
Welcome to the game “15”. Please try to arrange the numbers sequentially. Use 'top' to view the top scoreboard, 'restart' to start a new game and 'exit' to quit the game.
  ------------
 |  1  2  3  4 |
 |  5     7  8 |
 |  9  6 10 12 |
 | 13 14 11 15 |
  ------------
Enter a number to move: 6
  ------------
 |  1  2  3  4 |
 |  5  6  7  8 |
 |  9    10 12 |
 | 13 14 11 15 |
  ------------
Enter a number to move: 10
  ------------
 |  1  2  3  4 |
 |  5  6  7  8 |
 |  9 10    12 |
 | 13 14 11 15 |
  ------------
Enter a number to move: 3
Illegal move!
Enter a number to move: cheat
Illegal command!
Enter a number to move: 11
  ------------
 |  1  2  3  4 |
 |  5  6  7  8 |
 |  9 10 11 12 |
 | 13 14    15 |
  ------------
Enter a number to move: 15
  ------------
 |  1  2  3  4 |
 |  5  6  7  8 |
 |  9 10 11 12 |
 | 13 14 15    |
  ------------
Congratulations! You won the game in 4 moves.
Please enter your name for the top scoreboard: Bay Ivan
Scoreboard:
1. Bay Ivan --> 4 moves

Welcome to the game “15”. Please try to arrange the numbers sequentially. Use 'top' to view the top scoreboard, 'restart' to start a new game and 'exit' to quit the game.
  ------------
 |  15 2 12  4 |
 |  5     7  8 |
 |  9 11 10 12 |
 | 13 14  6  1 |
  ------------
Enter a number to move: restart

Welcome to the game “15”. Please try to arrange the numbers sequentially. Use 'top' to view the top scoreboard, 'restart' to start a new game and 'exit' to quit the game.
  ------------
 |  3  8 11  1 |
 | 15 13     5 |
 |  9 12 10  7 |
 |  2  4  6 14 |
  ------------
Enter a number to move: top
Scoreboard:
1. Bay Ivan --> 4 moves
  ------------
 |  3  8 11  1 |
 | 15 13     5 |
 |  9 12 10  7 |
 |  2  4  6 14 |
  ------------
Enter a number to move: 10
  ------------
 |  3  8 11  1 |
 | 15 13 10  5 |
 |  9 12     7 |
 |  2  4  6 14 |
  ------------
Enter a number to move: exit
Good bye!
Some players could try to cheat by entering illegal moves, so be cautious and prevent illegal input.

