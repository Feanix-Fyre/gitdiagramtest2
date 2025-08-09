# DoorController

Inherits from `NetworkBehaviour`.

## Description

A base class for networked, interactable doors. It manages the door's state (open/closed), access permissions for players, and automatic opening/closing for NPCs and players.

## Fields

-   **PlayerAccess**: `EDoorAccess` - Defines the access level for players (e.g., `Open`, `Locked`, `ExitOnly`).
-   **AutoOpenForPlayer**: `bool` - If true, the door will open automatically when a player with access approaches.
-   **InteriorIntObjs / ExteriorIntObjs**: `InteractableObject[]` - Arrays of interactable objects for the interior and exterior handles of the door.
-   **PlayerBlocker**: `BoxCollider` - A collider used to block players from passing through a door that has been opened by an NPC if the player does not have access.
-   **onDoorOpened**: `UnityEvent<EDoorSide>` - An event invoked when the door opens, passing the side from which it was opened.
-   **onDoorClosed**: `UnityEvent` - An event invoked when the door closes.

## Properties

-   **IsOpen**: `bool` (read-only) - Is the door currently open?
-   **openedByNPC**: `bool` (read-only) - Was the door last opened by an NPC?
-   **timeInCurrentState**: `float` (read-only) - The duration the door has been in its current state (open or closed).

## Core Logic

-   **Interaction**: The `InteriorHandleInteracted` and `ExteriorHandleInteracted` methods are called by the `InteractableObject`s. They check `CanPlayerAccess` and then call `SetIsOpen_Server` to change the door's state.
-   **Access Control**: The `CanPlayerAccess` method checks the `PlayerAccess` enum to determine if a player can use the door from a specific side.
-   **NPC & Player Vicinity**: The `NPCVicinityDetected` and `PlayerVicinityDetected` methods are called by `DoorSensor` triggers.
    -   If an NPC is detected and `OpenableByNPCs` is true, the door opens automatically.
    -   If a player is detected and `AutoOpenForPlayer` is true, the door opens automatically.
-   **Auto-Closing**: The `Update` loop contains logic to automatically close the door after a short delay once an NPC or player who triggered it has moved away. The `CheckAutoCloseForDistantPlayer` method also closes the door if all players are far away.
-   **Networking**: The state of the door is controlled by the server. Clients interact, which sends a `ServerRpc` (`SetIsOpen_Server`). The server then updates the state and broadcasts it to all clients via an `ObserversRpc` (`SetIsOpen`).

## Public Methods

### NPCVicinityDetected
`public virtual void NPCVicinityDetected(EDoorSide side)`

Called by a `DoorSensor` when an NPC is nearby. Triggers the door to open if it's not already.

### PlayerVicinityDetected
`public virtual void PlayerVicinityDetected(EDoorSide side)`

Called by a `DoorSensor` when a player is nearby. Triggers the door to open automatically if `AutoOpenForPlayer` is enabled.

### SetIsOpen
`public virtual void SetIsOpen(bool open, EDoorSide openSide)`

This is the client-side method, called by an RPC, that executes the logic for opening or closing the door, such as invoking the `onDoorOpened` or `onDoorClosed` events.
