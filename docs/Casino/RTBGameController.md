# RTBGameController

Inherits from `CasinoGameController`. (RTB likely stands for "Ride the Bus").

## Description

This class manages the entire lifecycle and logic for a networked game of "Ride the Bus". It's a multi-stage card guessing game where players try to correctly predict the outcome of the next card drawn. Players who guess incorrectly are eliminated, while those who guess correctly advance to the next stage with a higher bet multiplier.

## Enums

### EStage
Describes the current stage of the game.
-   `WaitingForPlayers`
-   `RedOrBlack` - Guess if the card is red or black.
-   `HigherOrLower` - Guess if the card is higher or lower than the previous one.
-   `InsideOrOutside` - Guess if the card's value is between or outside the values of the previous two cards.
-   `Suit` - Guess the suit of the card.

## Key Properties

-   **CurrentStage**: `EStage` (read-only) - The current stage of the game.
-   **IsQuestionActive**: `bool` (read-only) - Is the game currently waiting for player input?
-   **LocalPlayerBet**: `float` - The initial bet amount for the local player.
-   **LocalPlayerBetMultiplier**: `float` (read-only) - The current multiplier for the local player's bet.
-   **MultipliedLocalPlayerBet**: `float` (read-only) - The potential winnings for the local player.
-   **RemainingAnswerTime**: `float` (read-only) - Time left for the player to answer the current question.
-   **IsLocalPlayerInCurrentRound**: `bool` (read-only) - True if the local player is still in the game.

## Game Flow

1.  **WaitingForPlayers**: The game waits for all players at the table to mark themselves as "Ready".
2.  **RunRound**: When the game starts, it enters a `RunRound` coroutine for the first stage (`RedOrBlack`).
3.  **Ask Question**: A card is placed face-down. A question and possible answers are presented to the players (e.g., "Red or Black?"). A timer begins.
4.  **Reveal Answer**: After the timer ends or all players have answered, the card is flipped face-up.
5.  **Notify Players**: The server notifies clients of the correct answer. Players who guessed correctly have their `LocalPlayerBetMultiplier` increased and advance to the next stage. Players who guessed incorrectly are eliminated.
6.  **Advance Stage**: If there are still players in the round and the final stage (`Suit`) has not been reached, the game advances to the next stage and a new `RunRound` coroutine begins.
7.  **End Game**: The game ends when all players have been eliminated or after the final `Suit` stage is complete. Any remaining players are paid out based on their final bet multiplier. The game then resets to the `WaitingForPlayers` stage.

## Public Methods

### RemoveLocalPlayerFromGame
`public void RemoveLocalPlayerFromGame(bool payout, float cameraDelay = 0f)`

Removes the local player from the current round. If `payout` is true, their bet multiplied by the final `LocalPlayerBetMultiplier` is added to their balance.

-   **Parameters:**
    -   `payout`: Whether the player should be paid out (i.e., they won) or not (they were eliminated).
    -   `cameraDelay`: A delay before the camera moves back to the default position.

### SetLocalPlayerBet
`public void SetLocalPlayerBet(float bet)`

Sets the initial bet amount for the local player for the next game.

-   **Parameters:**
    -   `bet`: The desired bet amount.

### SetLocalPlayerAnswer
`public void SetLocalPlayerAnswer(float answer)`

Sets the local player's answer for the current question. The float corresponds to the button index (e.g., 1.0 for the first answer, 2.0 for the second).

-   **Parameters:**
    -   `answer`: The player's chosen answer.

### ToggleLocalPlayerReady
`public void ToggleLocalPlayerReady()`

Toggles the "Ready" state for the local player, used to start the game.
