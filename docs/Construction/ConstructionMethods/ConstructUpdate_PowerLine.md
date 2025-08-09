# ConstructUpdate_PowerLine

Inherits from `ConstructUpdate_Base`.

## Description

This class handles the per-frame logic for creating a `PowerLine`. Unlike other construction handlers that place a single object, this one manages a two-click process: first to select a starting `PowerNode`, and second to select an ending `PowerNode`.

## Fields

-   **ghostPowerLine_Material**: `Material` - The material used for the temporary "ghost" power line segments.
-   **cosmeticPowerNode**: `GameObject` - A visual indicator to show which power node is currently being hovered over by the mouse.
-   **startNode**: `protected PowerNode` - The first `PowerNode` selected by the player, which acts as the anchor for the new power line.

## Core Logic

1.  **State 1: No `startNode`**:
    -   The `Update` loop shows a HUD message: "Choose start point".
    -   It raycasts from the mouse to detect a `PowerNode`. If one is hovered, the `cosmeticPowerNode` is shown over it.
    -   On a primary click, the hovered node is set as the `startNode`.

2.  **State 2: `startNode` is selected**:
    -   The HUD message changes to "Choose end point".
    -   The `LateUpdate` loop draws a temporary power line made of ghost segments from the `startNode`'s connection point to the current mouse position in the world.
    -   If the mouse hovers over a valid, connectable end node, the ghost line snaps to it.
    -   On a primary click over a valid end node, `CompletePowerLine` is called.

3.  **Cancellation**: The player can press the `Exit` key (e.g., Escape) to cancel the process, which calls `StopCreatingPowerLine`.

## Key Methods

### GetHoveredPowerNode
`protected PowerNode GetHoveredPowerNode()`

Performs a raycast from the mouse cursor to find and return a `PowerNode` if one is being pointed at.

-   **Returns:** The `PowerNode` under the cursor, or `null`.

### CompletePowerLine
`private void CompletePowerLine(PowerNode target)`

Finalizes the creation of the power line.
-   It deducts the cost from the player's balance.
-   It calls `CreatePowerLine` on the `PowerManager` to create the actual, permanent power line between the `startNode` and the `target` node.
-   It notifies the `ConstructionManager` that a new object has been built.
-   If the player is holding Shift, it automatically starts creating the next power line segment from the `target` node, allowing for easy chaining. Otherwise, it resets the state.

### StopCreatingPowerLine
`private void StopCreatingPowerLine()`

Resets the power line creation state by clearing the `startNode` and hiding the temporary ghost segments.
