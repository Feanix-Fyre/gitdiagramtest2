# InteractionManager

Inherits from `Singleton<InteractionManager>`.

## Description

This singleton is the central hub for all player interactions with objects in the world. It is responsible for detecting which `InteractableObject` the player is looking at, managing the interaction UI prompt, and dispatching input events to the correct object.

## Key Properties

-   **interaction_SearchMask**: `LayerMask` - The layer mask used for raycasting to find interactable objects.
-   **interactionSearchType**: `EInteractionSearchType` - Determines whether to raycast from the camera's center or the mouse position.
-   **hoveredInteractableObject**: `InteractableObject` (read-only) - The interactable object the player is currently looking at, regardless of its state.
-   **hoveredValidInteractableObject**: `InteractableObject` (read-only) - The interactable object the player is looking at, but only if it's in a valid, non-disabled state.
-   **interactedObject**: `InteractableObject` (read-only) - The object the player is currently holding the interaction button down on.

## Core Logic

-   **Hover Detection (`CheckHover`)**: In `LateUpdate`, this method performs the search for interactable objects.
    1.  It first checks a series of conditions to see if interaction should be disabled entirely (e.g., UI is open, player is in a vehicle, an item that blocks interaction is equipped).
    2.  It performs a `SphereCastAll` based on the `interactionSearchType`.
    3.  It sorts all hit objects by their `Priority` and then by distance.
    4.  It sets `hoveredInteractableObject` to the highest-priority, closest valid object.
    5.  It then calls the `Hovered()` method on that object.

-   **Interaction (`CheckInteraction`)**:
    -   If there is a `hoveredValidInteractableObject`, this method checks for player input (either the interact key or primary mouse click, depending on the object's `EInteractionType`).
    -   When the button is pressed, it calls `StartInteract()` on the object and sets it as the `interactedObject`.
    -   When the button is released, it calls `EndInteract()` on the `interactedObject` and clears the reference.

-   **Right-Click Destruction (`CheckRightClick`)**:
    -   In `Update`, this method handles a separate interaction for destroying buildable items.
    -   If the player holds the right mouse button while looking at a `BuildableItem`, it begins a timer.
    -   When the timer (`timeToDestroy`) is filled, the item's `PickupItem()` method is called.
    -   It uses the HUD's radial indicator to show the progress.

## Public Methods

### EnableInteractionDisplay
`public void EnableInteractionDisplay(Vector3 pos, Sprite icon, string spriteText, string message, Color messageColor, Color iconColor)`

This method is called by `InteractableObject.ShowMessage()` to display the UI prompt. It sets the position, content, and color of the interaction display canvas elements.

### LerpDisplayScale
`public void LerpDisplayScale(float endScale)`

Animates the scale of the interaction display, typically used to create a "pop" effect when an interaction starts or ends.
