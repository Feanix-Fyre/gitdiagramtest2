# Equippable_Pourable

Inherits from `Equippable_Viewmodel`.

## Description

A base class for equippable items that can be poured, typically into a `Pot`. It handles detecting when the player is looking at a valid target and initiating the appropriate "pour" task.

## Fields

-   **InteractionRange**: `float`
    -   The maximum distance at which the player can interact with a pourable target.
-   **PourablePrefab**: `Pourable`
    -   A prefab that is instantiated to create the visual effect of pouring (e.g., a stream of liquid).

## Properties

-   **InteractionLabel**: `string`
    -   The text that will be displayed on the interaction prompt (e.g., "Pour Water", "Apply Additive").

## Core Logic

-   **Target Detection (`Update`)**: The `Update` loop continuously raycasts from the player's camera.
    -   If the raycast hits a `Pot`, it calls `CanPour()` to check if the interaction is valid.
    -   If valid, it configures the `Pot`'s interaction prompt with the `InteractionLabel`.
    -   If invalid, it can display a `reason` message on the prompt.
    -   If the player clicks the interact button while looking at a valid `Pot`, it calls `StartPourTask()`.

## Methods

### StartPourTask
`protected virtual void StartPourTask(Pot pot)`

A virtual method that starts the player task for pouring. The base implementation starts a generic `PourIntoPotTask`. This is intended to be overridden by derived classes for more specific actions (e.g., `Equippable_Additive` starts an `ApplyAdditiveToPot` task).

-   **Parameters:**
    -   `pot`: The target `Pot` to pour into.

### CanPour
`protected virtual bool CanPour(Pot pot, out string reason)`

A virtual method to check if the item can be poured into the specified `pot`. The base implementation always returns `true`. This is intended to be overridden by derived classes to add specific validation logic.

-   **Parameters:**
    -   `pot`: The target `Pot`.
    -   `reason`: An `out` parameter for displaying a message if the action is invalid.
-   **Returns:** `true` if the item can be poured, otherwise `false`.
