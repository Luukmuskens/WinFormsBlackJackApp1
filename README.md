# Blackjack in C++

## Overview
This C++ application is a simple implementation of the classic card game Blackjack. The goal of the game is to have a hand with a value as close to 21 as possible without exceeding it ("bust"). The player competes against the dealer.

## Features
- Draw cards and decide whether to hit or stand.
- Automatic dealer logic.
- Basic Blackjack rules, including "Blackjack" (21 with the first two cards).
- Simple command-line interface.

## Installation
1. Ensure you have a C++ compiler installed, such as `g++` (e.g., via MinGW for Windows or `build-essential` on Linux).
2. Clone or download the source code from this repository.
3. Navigate to the directory containing the code and compile the file:
   ```sh
   g++ blackjack.cpp -o blackjack
   ```
4. Run the game:
   ```sh
   ./blackjack
   ```

## Rules of the Game
1. The player and the dealer both start with two cards.
2. The player can choose to draw an extra card (`hit`) or stop (`stand`).
3. If the player exceeds 21, they lose immediately.
4. The dealer plays according to fixed rules (e.g., drawing cards until reaching at least 17).
5. The player wins if they are closer to 21 than the dealer without "busting".

## Code Structure
- `blackjack.cpp`: Contains the main game logic.
- `deck.h` and `deck.cpp`: Handle card generation and shuffling.
- `player.h` and `player.cpp`: Contain player and dealer logic.

## Future Enhancements
- Implementation of splitting and doubling down.
- Betting system with virtual money.
- Graphical interface with a GUI.

## Author
Luuk Muskens

Enjoy the game!

