# UltimateTicTacToe PS3

A version of Ultimate Tic Tac Toe, made in Unity, but downgraded to Unity 5.4.0b3 for PS3 build support. This build of the game includes controller support for UI and gameplay, along with other small fixes.


## Screenshots
![](images/UltimateTicTacToe%20PS3%20XMB.png)
![](images/UltimateTicTacToe%20PS3%20in-game.png)
![](images/UltimateTicTacToe%20PS3%20in-game%202.png)



## How to play
This tic-tac-toe game consists of 9 smaller tic-tac-toe games. In order to win the game, you need to win in 3 smaller games in a row.
There's a twist though, depending on which box you choose inside of one of the smaller boards, your opponent is locked to that same tile on the big board next round.

For instance, if you play in the bottom right tile of a small board, your opponent will only be able to play within the bottom right game. It's hard to explain in text, but becomes pretty clear when you play. During your turn, you can only play where the green box is.



## Compiling

To compile the game, you will need the Unity PS3 SDK. The best way to get this set up is to find a file online called "Unity PS3 + SDK Full installer v1.8.zip". I would link to it, but I don't believe I can legally redistribute it.

With that zip file obtained, just run through the batch script. When it gets to the SDK portion, just check everything with the checkbox at the top.

## Installing and playing on real hardware

To play the game on a real PS3, you may need to enable DEX mode, I'm still not totally clear on this. When in CEX mode, the game installs and launches, but hangs on a black screen after launching. In DEX mode, the game installs and launches properly. 

Unfortunately, I believe this means that the game requires a CFW-compatible PS3, which would be a shame. If anyone has any advice, I'd love to hear it and would happily try to compile the game again.



## Installing and playing on RPCS3

The game can be installed using RPCS3's install PKG function, but the emulator will crash when launching the game. Haven't figured out why just yet.



## Final notes

If you have any trouble running the game, any questions, or any cool ideas to add to the game, feel free to make an issue on the GitHub repo! I'd love to hear it.