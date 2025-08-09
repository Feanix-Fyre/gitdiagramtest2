# ItemPickup

Requires an `InteractableObject` component. Inherits from `NetworkBehaviour`.

## Description

This class represents a physical item in the game world that can be picked up by the player. When the player interacts with it, the corresponding item is added to their inventory.

## Fields

-   **ItemToGive**: `ItemDefinition`
    -   The `ItemDefinition` of the item that will be given to the player upon pickup.
-   **DestroyOnPickup**: `bool`
    -   If true, the pickup's GameObject will be destroyed after it is picked up.
-   **ConditionallyActive**: `bool`
    -   If true, the pickup will only be active if the `ActiveCondition` is met.
-   **ActiveCondition**: `Condition`
    -   A `Condition` that must be met for the pickup to be active in the world.
-   **Networked**: `bool`
    -   If true, the object's destruction will be synchronized over the network.
-   **IntObj**: `InteractableObject`
    -   A reference to the `InteractableObject` component on this GameObject.
-   **onPickup**: `UnityEvent`
    -   An event that is invoked when the item is successfully picked up.

## Core Logic

-   **Initialization (`Start`/`Init`)**: When the local player spawns, the `Init` method checks the `ActiveCondition` (if any) and deactivates the GameObject if the condition is not met.
-   **Interaction (`Hovered`/`Interacted`)**:
    -   When the player hovers over the object, the `Hovered` method is called. It checks `CanPickup()` to see if the player has room in their inventory.
    -   If they do, it sets the interaction message to "Pick up [Item Name]".
    -   If not, it sets the message to "Inventory Full".
    -   When the player interacts, the `Interacted` method calls `Pickup()`.
-   **Pickup Logic (`Pickup`)**:
    -   The `Pickup` method adds a new instance of the `ItemToGive` to the player's inventory.
    -   It invokes the `onPickup` event.
    -   If `DestroyOnPickup` is true, it either destroys the object locally or calls the `Destroy` `ServerRpc` to destroy it across the network.

## Methods

### CanPickup
`protected virtual bool CanPickup()`

Checks if the player's inventory has space for the item.

-   **Returns:** `true` if the item can fit in the player's inventory, otherwise `false`.

### Pickup
`protected virtual void Pickup()`

Handles the logic of giving the item to the player and destroying the pickup object.

### Destroy
`public void Destroy()`

A `ServerRpc` that despawns and destroys the pickup's `NetworkObject` so that it is removed for all players.
