For the singleton, Player 1 and player 2 are both singletons (along with the gamemanager). 
There should only be one instance of each player, and the gamemanager checks the players height constantly.
If both players are above a certain height (the top of the level), the gamemanager recognizes this and finishes the level.

Factory(unfinished) is a player factory. The player factory spawns the player, with a specific material, and specific keybinds for controls (player 1 and 2).
There are inherited factories, for player1 and player2, so that it can give the proper singleton scripts.
this is for if say a player dies, they can respawn a specific player, or also change the colour of them.
