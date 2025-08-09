# DragManager

Inherits from `NetworkSingleton<DragManager>`.

## Description

This singleton manager handles all logic related to picking up, dragging, and throwing physics-based objects (`Draggable`s). It applies forces to the dragged object to make it follow the player's view and synchronizes the state of dragged objects across the network.

## Key Fields & Properties

-   **ThrowSound**: `AudioSourceController` - The sound effect played when an object is thrown.
-   **DragForce**: `float` - The force applied to pull the object towards the target position.
-   **DampingFactor**: `float` - Damping applied to the object's linear velocity to prevent overshooting.
-   **TorqueForce**: `float` - The force applied to rotate the object to match the player's view.
-   **TorqueDampingFactor**: `float` - Damping applied to the object's angular velocity.
-   **ThrowForce**: `float` - The base force applied when throwing an object.
-   **MassInfluence**: `float` - A factor determining how much the object's mass affects the throw force (heavier objects are thrown with less force).
-   **CurrentDraggable**: `Draggable` (read-only) - The `Draggable` object currently being held by the local player.
-   **IsDragging**: `bool` (read-only) - True if the player is currently dragging an object.

## Core Logic

1.  **Starting a Drag**:
    -   A player interacts with a `Draggable` object.
    -   `StartDragging(Draggable draggable)` is called.
    -   The `CurrentDraggable` is set.
    -   The `Draggable` itself is notified via `draggable.StartDragging()`.
    -   An RPC (`SendDragger`) is sent to the server to inform other clients that this object is being dragged by this player.

2.  **During a Drag (`FixedUpdate`)**:
    -   If an object is being dragged, `CurrentDraggable.ApplyDragForces()` is called every physics update.
    -   `ApplyDragForces` (on the `Draggable` object) calculates and applies forces to move the object towards a target position just in front of the player's camera (`GetTargetPosition()`).

3.  **Stopping a Drag (`Update`)**:
    -   Dragging stops if the player presses the interact button again, if `IsDraggingAllowed()` becomes false (e.g., UI opens), or if the object gets too far away.
    -   `StopDragging()` is called, which notifies the `Draggable` and sends an RPC to clear the dragger on other clients.
    -   It also sends an RPC (`SendDraggableTransformData`) to synchronize the object's final position, rotation, and velocity.

4.  **Throwing (`Update`)**:
    -   If the player presses the primary mouse button while dragging, the object is thrown.
    -   A force is calculated based on `ThrowForce` and `MassInfluence` and added to the object's velocity.
    -   The `ThrowSound` is played.
    -   `StopDragging()` is called immediately after, passing the new velocity to be synchronized.

## Public Methods

### RegisterDraggable / Deregister
`public void RegisterDraggable(Draggable draggable)` and `public void Deregister(Draggable draggable)`

Methods for `Draggable` objects to add or remove themselves from the manager's master list upon creation and destruction.

### StartDragging
`public void StartDragging(Draggable draggable)`

Begins the process of dragging an object for the local player.

### StopDragging
`public void StopDragging(Vector3 velocity)`

Ends the dragging process and synchronizes the object's final state.

### IsDraggingAllowed
`public bool IsDraggingAllowed()`

A helper method that checks various game states (UI open, player dead, item equipped, etc.) to determine if the player is currently allowed to drag objects.
