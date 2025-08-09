# PayPhone

Inherits from `MonoBehaviour`.

## Description

This class controls the behavior of a payphone in the game world. It can ring to signal a `QueuedCall` from the `CallManager`, and the player can interact with it to answer the call.

## Constants

-   **RING_INTERVAL**: `float` - The time in seconds between rings (4 seconds).
-   **RING_RANGE**: `float` - The maximum distance from the player at which the phone will ring (9 units).

## Fields

-   **Light**: `BlinkingLight`
    -   A reference to a `BlinkingLight` component that will flash when a call is queued.
-   **RingSound**: `AudioSourceController`
    -   The audio source for the ringing sound effect.
-   **AnswerSound**: `AudioSourceController`
    -   The audio source for the sound effect when the phone is answered.
-   **IntObj**: `InteractableObject`
    -   The `InteractableObject` component for the payphone.
-   **CameraPosition**: `Transform`
    -   The position and rotation the player's camera should move to when answering the call.

## Properties

-   **QueuedCall**: `PhoneCallData` (read-only)
    -   Gets the currently queued call from the `CallManager`.
-   **ActiveCall**: `PhoneCallData` (read-only)
    -   Gets the currently active call from the `CallInterface`.

## Methods

### FixedUpdate
`public void FixedUpdate()`

Periodically checks if there is a queued call and if the player is within range. If so, it makes the light blink and plays the `RingSound` at intervals.

### Hovered
`public void Hovered()`

Called when the player's crosshair is over the payphone. It updates the interaction message on the `InteractableObject` to "Answer phone" if a call can be answered.

### Interacted
`public void Interacted()`

Called when the player interacts with the payphone. If a call can be answered, it starts the call via the `CallInterface`, stops the ringing, plays the answer sound, and moves the player's camera to the `CameraPosition`.

### CanInteract
`private bool CanInteract()`

Checks if the player is allowed to answer the phone. This is true if there is a queued call, no other call is active, and the call interface is not already open.
