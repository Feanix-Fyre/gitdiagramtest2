# NetworkedInteractableToggleable

Inherits from `NetworkBehaviour`.

## Description

This class provides functionality for an `InteractableObject` that can be toggled between an "on" and "off" state, with its state synchronized across the network. It is the networked version of `InteractableToggleable`.

## Fields

-   **ActivateMessage**: `string` - The message displayed when the object is off (e.g., "Turn On").
-   **DeactivateMessage**: `string` - The message displayed when the object is on (e.g., "Turn Off").
-   **CoolDown**: `float` - The time in seconds before the object can be toggled again.
-   **IntObj**: `InteractableObject` - A reference to the associated `InteractableObject`.
-   **onToggle**: `UnityEvent` - Invoked every time the object is toggled.
-   **onActivate**: `UnityEvent` - Invoked only when the object is turned on.
-   **onDeactivate**: `UnityEvent` - Invoked only when the object is turned off.

## Properties

-   **IsActivated**: `bool` (read-only) - The current state of the toggleable object.

## Core Logic

-   **Initialization (`Start`)**: It subscribes its `Hovered` and `Interacted` methods to the `onHovered` and `onInteractStart` events of the `IntObj`.
-   **Hover Logic (`Hovered`)**: When the player looks at the object, this method checks if the cooldown has passed. If not, it disables the interaction. If it has, it sets the interaction message to either `ActivateMessage` or `DeactivateMessage` based on the `IsActivated` state.
-   **Interaction Logic (`Interacted`)**: When the player interacts, this calls `SendToggle()`.
-   **Networking**:
    1.  `SendToggle()` is a `ServerRpc` that tells the server to toggle the state.
    2.  The server then calls the `SetState()` `ObserversRpc`.
    3.  `SetState()` is executed on all clients, updating the `IsActivated` property and invoking the appropriate events (`onToggle`, `onActivate`/`onDeactivate`). This ensures the state change is synchronized for all players.

## Public Methods

### SetState
`public void SetState(NetworkConnection conn, bool activated)`

The `ObserversRpc` that changes the object's state and invokes the relevant events. This is the method that all clients execute to stay in sync.

-   **Parameters:**
    -   `conn`: The network connection (unused, part of the RPC signature).
    -   `activated`: The new state for the object.

### PoliceDetected
`public void PoliceDetected()`

A special method that can be called to force the object into the "on" state if it is not already, by sending a toggle request to the server.
