# SlotMachine

Inherits from `NetworkBehaviour`.

## Description

This class controls a networked slot machine. It handles player interactions for setting a bet and pulling the handle, communicates with the server to get a result, and plays the corresponding animations and sounds for the spin and the outcome.

## Enums

### ESymbol
The symbols that can appear on the reels.
-   `Cherry`, `Lemon`, `Grape`, `Watermelon`, `Bell`, `Seven`

### EOutcome
The possible win/loss outcomes of a spin.
-   `Jackpot`, `BigWin`, `SmallWin`, `MiniWin`, `NoWin`

## Fields

-   **BetAmounts**: `static int[]` - An array of possible bet values (5, 10, 25, 50, 100).
-   **DownButton/UpButton**: `InteractableObject` - Interaction objects for increasing/decreasing the bet.
-   **HandleIntObj**: `InteractableObject` - The interaction object for the main handle.
-   **BetAmountLabel**: `TextMeshPro` - The text display for the current bet amount.
-   **Reels**: `SlotReel[]` - An array of the `SlotReel` components that make up the machine.
-   **SpinLoop**: `AudioSourceController` - The looping sound played while the reels are spinning.
-   **ScreenAnimation**: `Animation` - The animation component for the win/jackpot screen display.
-   **JackpotParticles**: `ParticleSystem[]` - Particle effects for a jackpot win.
-   **Win-related fields**: Various `AnimationClip` and `AudioSourceController` fields for different win levels.

## Properties

-   **IsSpinning**: `bool` (read-only) - True if the machine is currently in the middle of a spin.

## Gameplay Flow

1.  **Betting**: The player interacts with the `UpButton` and `DownButton` to cycle through the `BetAmounts`. This sends an RPC to the server to update the bet index.
2.  **Spinning**: The player interacts with the `HandleIntObj`.
    -   The client deducts the bet amount from their `MoneyManager`.
    -   It sends a `SendStartSpin` RPC to the server, including the player's connection and bet amount.
3.  **Server Logic**:
    -   The server receives the `SendStartSpin` request.
    -   It determines a random outcome (an array of `ESymbol`s, one for each reel).
    -   It sends an `ObserversRpc` (`StartSpin`) back to all clients with the determined symbols.
4.  **Client-Side Spin and Outcome**:
    -   All clients receive the `StartSpin` RPC and begin the spin animation locally.
    -   The `Spin` coroutine starts, spinning each reel in sequence.
    -   After a delay, the reels stop on the symbols provided by the server.
    -   The client evaluates the outcome based on the symbols (`EvaluateOutcome`).
    -   The client calculates the win amount (`GetWinAmount`).
    -   The client displays the appropriate win animation and sound (`DisplayOutcome`).
    -   If the winning player is the local player, the win amount is added to their `MoneyManager`.

## Public Methods

### HandleInteracted
`public void HandleInteracted()`

Called when the player pulls the handle. It checks if a spin is possible, deducts the bet from the player's balance, and sends an RPC to the server to start the spin.

### SetBetIndex
`public void SetBetIndex(NetworkConnection conn, int index)`

An RPC to set the current bet index, which determines the bet amount. This is synchronized across clients.
