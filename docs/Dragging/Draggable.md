# Draggable

Requires `Rigidbody` and `InteractableObject` components. Implements `IGUIDRegisterable`.

## Description

This component makes a GameObject a physics-based object that can be picked up, dragged, and thrown by the player. It works in conjunction with the `DragManager`.

## Enums

### EInitialReplicationMode
Defines how the object's transform is synchronized when a new player joins.
-   **Off**: No initial synchronization.
-   **OnlyIfMoved**: Synchronize only if the object has moved significantly from its starting position.
-   **Full**: Always synchronize.

## Key Fields & Properties

-   **Rigidbody**: `Rigidbody` - A reference to the object's Rigidbody component.
-   **IntObj**: `InteractableObject` - The interactable component for this object.
-   **DragOrigin**: `Transform` - The point on the object that will be pulled towards the player's target position. If not set, the object's center of mass is used.
-   **HoldDistanceMultiplier**: `float` - A multiplier for how far away the object is held from the player.
-   **onDragStart / onDragEnd**: `UnityEvent` - Events invoked when dragging starts and stops.
-   **IsBeingDragged**: `bool` (read-only) - Is this object currently being dragged by any player?
-   **CurrentDragger**: `Player` (read-only) - The `Player` who is currently dragging this object.
-   **GUID**: `Guid` (read-only) - The unique identifier for this draggable object.

## Core Logic

-   **Registration**: In `Start`, the object registers itself with the `DragManager`.
-   **Interaction**:
    -   The `Hovered` method checks `CanInteract` and updates the `IntObj`'s state and message.
    -   The `Interacted` method is called when the player clicks on the object. If `CanInteract` is true, it calls `DragManager.StartDragging(this)`.
-   **Drag State**:
    -   `StartDragging(Player dragger)` is called by the `DragManager` on all clients. It sets the `CurrentDragger` and disables gravity on the `Rigidbody`.
    -   `StopDragging()` is called by the `DragManager`. It clears the `CurrentDragger` and re-enables gravity.
-   **Physics (`ApplyDragForces`)**:
    -   This public method is called by the `DragManager` during `FixedUpdate`.
    -   It calculates a force to pull the `DragOrigin` towards a `targetPosition` in front of the player's camera.
    -   It applies a damping force to prevent the object from overshooting and oscillating.
    -   It applies a torque to make the object's "up" vector align with the world's "up", preventing it from tumbling wildly while being dragged.

## Public Methods

### SetGUID
`public void SetGUID(Guid guid)`

Allows the object's GUID to be set externally, usually during instantiation from a save file.

### ApplyDragForces
`public void ApplyDragForces(Vector3 targetPosition)`

Calculates and applies the necessary forces to the `Rigidbody` to move it towards the target position while being dragged.

### StartDragging
`public void StartDragging(Player dragger)`

Puts the object into the "dragged" state.

### StopDragging
`public void StopDragging()`

Takes the object out of the "dragged" state.
