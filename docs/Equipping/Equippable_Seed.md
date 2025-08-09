# Equippable_Seed

Inherits from `Equippable_Viewmodel`.

## Description

This class represents an equippable seed item, which can be sown in a `Pot`. It handles detecting when the player is looking at a valid pot and initiating the `SowSeedTask`.

## Fields

-   **Seed**: `SeedDefinition`
    -   A reference to the `SeedDefinition` ScriptableObject that defines the type of seed this is.

## Core Logic

-   **Target Detection (`Update`)**: The `Update` loop continuously raycasts from the player's camera.
    -   If the raycast hits a `Pot`, it calls the pot's `CanAcceptSeed()` method to check if the interaction is valid.
    -   If valid, it configures the `Pot`'s interaction prompt to show "Sow seed".
    -   If invalid, it displays the reason message provided by `CanAcceptSeed` on the prompt.
    -   If the player clicks the interact button while looking at a valid `Pot`, it calls `StartSowSeedTask()`.

## Methods

### StartSowSeedTask
`protected virtual void StartSowSeedTask(Pot pot)`

Starts a new `SowSeedTask`, which handles the logic and animation for planting the `Seed` in the target `pot`.

-   **Parameters:**
    -   `pot`: The target `Pot` to sow the seed in.
