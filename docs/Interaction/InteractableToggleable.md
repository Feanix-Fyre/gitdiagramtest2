# InteractableToggleable

Inherits from `MonoBehaviour`.

## Description

This class provides functionality for an `InteractableObject` that can be toggled between an "on" and "off" state. It manages the interaction messages and invokes different events based on its current state.

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
-   **Interaction Logic (`Interacted`)**: When the player interacts, this simply calls `Toggle()`.

## Public Methods

### Toggle
`public void Toggle()`

Flips the `IsActivated` state, resets the `lastActivated` cooldown timer, and invokes the appropriate events (`onToggle`, and either `onActivate` or `onDeactivate`).

### SetState
`public void SetState(bool activated)`

Forces the object into a specific state without invoking the general `onToggle` event. It only invokes `onActivate` or `onDeactivate` if the state actually changes.

-   **Parameters:**
    -   `activated`: The new state for the object.

### PoliceDetected
`public void PoliceDetected()`

A special method that forces the object into the "on" state if it is not already.
