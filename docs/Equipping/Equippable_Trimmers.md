# Equippable_Trimmers

Inherits from `Equippable_Viewmodel`.

## Description

This class represents an equippable pair of trimmers, used for harvesting mature plants from a `Pot`. It handles detecting when the player is looking at a harvestable plant and initiating the `HarvestPlant` task.

## Fields

-   **CanClickAndDrag**: `bool`
    -   A flag passed to the `HarvestPlant` task, likely to determine the interaction mode for harvesting.
-   **SoundLoopPrefab**: `AudioSourceController`
    -   A prefab containing the looping sound effect that plays during the harvesting process.

## Core Logic

-   **Target Detection (`Update`)**: The `Update` loop continuously raycasts from the player's camera.
    -   If the raycast hits a `Pot`, it calls the pot's `IsReadyForHarvest()` method to check if the plant can be harvested.
    -   If it is ready, it configures the `Pot`'s interaction prompt to show "Harvest".
    -   If it is not ready, it displays the reason message provided by `IsReadyForHarvest` on the prompt.
    -   If the player clicks the interact button while looking at a harvestable `Pot`, it creates a new `HarvestPlant` task, passing itself the `CanClickAndDrag` flag and the `SoundLoopPrefab`.
