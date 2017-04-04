# Othelo-Game
Designing the Othelo game, as described in Cracking the Coding Interview book with slight changes (changes are shown by *)

1) Othello is a strategy game played by two players: Black and White (Player1 and Player2 respectively).
2) It is played on an nxn board (we have fixed the board size to 10x10).
3) There are maximum of nxn (100 in this version) pieces, each of which is black on one side and white on the other.
4) At the beginning of the game, two black and two peices are placed in the middle of the board. Top left and bottom right are black pieces.
5) Black player always starts the game.
6) At each turn, the player should place a piece of his color, on an empty cell, adjacent (horizontally and vertically, not diagnally*) to opponent's disc.
7) The move is valid if the player can trap the opponent's piece or pieces. The piece will be flipped, if it's surrounded by two of the opponent's pieces, to it's right, left, top or buttom.
8) If a payer at any point doesn't have a valid move, they can pass their turn*.
9) The game is finished, when all the cells of the board are filled with pieces, or:
10) At any point of the game, if a player's pieces are down to 0, the opponent is the winner*.

--Disregard my spell error (OTHELLO*). Oops!
