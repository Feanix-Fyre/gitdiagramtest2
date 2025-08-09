# Equippable_Cuke

Inherits from `Equippable_Viewmodel`. ("Cuke" is likely short for Cucumber, a brand of drink in the game).

## Description

This class represents a consumable drink item. When used, it plays an animation, applies effects to the player (like restoring energy and stamina), and then spawns a piece of trash.

## Fields

-   **BaseEnergyGain**: `float` - The amount of energy restored by the first drink.
-   **MinEnergyGain**: `float` - The minimum amount of energy that can be restored.
-   **ConsecutiveReduction**: `float` - A multiplier (0 to 1) applied to energy gain for each consecutive drink, creating diminishing returns.
-   **HealthGain**: `float` - The amount of health restored by the drink.
-   **AnimationDuration**: `float` - The length of the drinking animation.
-   **ClearDrugEffects**: `bool` - If true, consuming this drink will clear any active drug effects on the player.
-   **OpenAnim / DrinkAnim**: `Animation` - References to the `Animation` components for opening the can and drinking.
-   **OpenSound / SlurpSound**: `AudioSourceController` - Sound effects for opening and drinking.
-   **TrashPrefab**: `TrashItem` - The prefab for the empty can that is created after consumption.

## Properties

-   **IsDrinking**: `bool` (read-only) - True if the drinking animation and coroutine are currently active.

## Core Logic

-   **Input**: The `Update` method checks for a primary mouse click. If the player clicks and is not already drinking, it calls `Drink()`.
-   **Drinking Process**:
    1.  The `Drink()` method starts the `DrinkRoutine` coroutine.
    2.  The coroutine plays the open and drink animations and sounds.
    3.  It waits for the `AnimationDuration`.
    4.  It calls `ApplyEffects()` to modify the player's stats.
    5.  It creates an empty can (`TrashPrefab`) in the world.
    6.  It consumes one item from the inventory stack (`itemInstance.ChangeQuantity(-1)`).
    7.  If more of the item remains in the stack, it calls `Reequip()` to show a new one.

## Methods

### Drink
`public void Drink()`

Initiates the drinking process by starting the `DrinkRoutine` coroutine.

### ApplyEffects
`public void ApplyEffects()`

Calculates and applies the stat changes to the player.
-   It calculates energy gain with diminishing returns based on `Player.Local.Energy.EnergyDrinksConsumed`.
-   It restores player energy and fully restores their stamina.
-   It restores health if `HealthGain` is greater than zero.
-   It optionally clears active drug effects.
