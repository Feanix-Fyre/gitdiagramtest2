# ConstructUpdate_PowerTower

Inherits from `ConstructUpdate_OutdoorGrid`.

## Description

This class provides a specialized construction handler for placing `PowerTower`s. It extends the grid-based placement logic from `ConstructUpdate_OutdoorGrid` by adding the functionality to simultaneously create a `PowerLine` connecting the new tower to an existing `PowerNode`.

## Fields

-   **powerLine_GhostMat**: `Material` - The material for the temporary "ghost" power line preview.
-   **cosmeticPowerNode**: `GameObject` - A visual indicator to show which power node is currently being hovered over.
-   **startNode**: `protected PowerNode` - The existing `PowerNode` from which the new power line will originate.

## Core Logic

This class combines two distinct modes of operation, managed within its `Update` and `LateUpdate` loops.

1.  **Connecting to an Existing Node (No `startNode`)**:
    -   The player can hover over an existing `PowerNode`. When they do, the ghost model of the power tower is hidden, and the `cosmeticPowerNode` indicator appears over the hovered node.
    -   If the player clicks on a valid node, it is selected as the `startNode`, and the system transitions to the next state.

2.  **Placing the New Tower (`startNode` is selected)**:
    -   The ghost model of the power tower becomes visible and follows the logic from the parent `ConstructUpdate_OutdoorGrid` class, snapping to the outdoor grid under the mouse cursor.
    -   Simultaneously, a temporary "ghost" power line is drawn from the `startNode` to the connection point of the power tower ghost model.
    -   The placement is only considered valid if both the tower's grid position is valid AND the distance to the `startNode` is within the `PowerLine.maxLineLength`.
    -   If the player clicks on a valid grid location, `PlaceNewConstructable` is called.

3.  **Connecting Two Existing Nodes**:
    -   The player can also choose to simply connect two existing nodes without placing a new tower. The logic for drawing the ghost power line and finalizing the connection is also handled here.

## Key Methods

### PlaceNewConstructable
`protected override Constructable_GridBased PlaceNewConstructable()`

Overrides the base method. After placing the new power tower using the parent class's logic, it also calls `CreatePowerLine` on the `PowerManager` to create the power line between the `startNode` and the new tower's `PowerNode`. It then sets the new tower as the `startNode`, allowing for easy chaining of power tower placements.

### CompletePowerLine
`private void CompletePowerLine(PowerNode target)`

Finalizes the creation of a power line between the `startNode` and another existing `PowerNode` (`target`). This is used when the player is just connecting existing nodes without placing a new tower.

### GetHoveredPowerNode
`protected PowerNode GetHoveredPowerNode()`

Performs a raycast from the mouse cursor to find and return a `PowerNode` if one is being pointed at.
