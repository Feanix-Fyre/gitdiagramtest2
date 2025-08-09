# InteractableObject

Inherits from `MonoBehaviour`.

## Description

This class is the base component for any object in the world that the player can interact with. It manages the object's interaction state, range, and the message displayed to the player. It works in conjunction with the `InteractionManager`.

## Enums

### EInteractionType
Defines how the player interacts with the object.
-   **Key_Press**: The player uses the designated "interact" key (e.g., 'E').
-   **LeftMouse_Click**: The player uses the primary mouse button.

### EInteractableState
Defines the current state of the interaction.
-   **Default**: A normal, valid interaction.
-   **Invalid**: The interaction is currently not possible (e.g., a locked door). An error icon and message are shown.
-   **Disabled**: The interaction is completely disabled and shows no UI.
-   **Label**: Shows only a text label without an interaction icon.

## Fields

-   **message**: `string` - The text to display to the player (e.g., "Open Door", "Pick Up").
-   **interactionType**: `EInteractionType` - The type of input required for this interaction.
-   **interactionState**: `EInteractableState` - The current state of the interactable.
-   **MaxInteractionRange**: `float` - The maximum distance from which the player can interact with this object.
-   **RequiresUniqueClick**: `bool` - If true, the player must release and re-press the interact button to trigger the interaction again.
-   **Priority**: `int` - A priority value used by the `InteractionManager` to decide which object to interact with when multiple are in range.
-   **displayLocationPoint**: `Transform` - A specific point where the interaction UI should appear. If null, the object's main transform position is used.
-   **LimitInteractionAngle**: `bool` - If true, the player must be within a certain angle to interact.
-   **AngleLimit**: `float` - The maximum angle (in degrees) from the object's forward vector that the player can be to interact.
-   **onHovered / onInteractStart / onInteractEnd**: `UnityEvent` - Events that are invoked when the player hovers over, starts interacting with, or stops interacting with the object.

## Methods

### SetMessage / SetInteractableState
`public void SetMessage(string _message)` and `public void SetInteractableState(EInteractableState state)`

Public methods to allow other scripts to change the interaction message and state at runtime.

### Hovered
`public virtual void Hovered()`

Called by the `InteractionManager` when the player is looking at this object. It invokes the `onHovered` event and calls `ShowMessage`.

### StartInteract / EndInteract
`public virtual void StartInteract()` and `public virtual void EndInteract()`

Called by the `InteractionManager` when the player presses or releases the interact button. They invoke the corresponding `onInteractStart` and `onInteractEnd` events.

### ShowMessage
`protected virtual void ShowMessage()`

Gathers all the necessary data (message, state, icon type) and calls `EnableInteractionDisplay` on the `InteractionManager` to show the UI prompt to the player.

### CheckAngleLimit
`public bool CheckAngleLimit(Vector3 interactionSource)`

Checks if the player (the `interactionSource`) is within the allowed `AngleLimit` for interaction.
