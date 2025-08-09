# CallManager

Inherits from `Singleton<CallManager>`.

## Description

This manager handles the queueing of phone calls. It allows a script to "queue" a `PhoneCallData` object, which can then be initiated by another part of the game, typically a payphone.

## Properties

-   **QueuedCallData**: `PhoneCallData` (read-only)
    -   The `PhoneCallData` for the call that is currently queued up.

## Methods

### Start
`protected override void Start()`

Subscribes the `CallCompleted` method to the `CallCompleted` event on the `CallInterface` singleton. This allows the manager to know when a call has finished.

### OnDestroy
`protected override void OnDestroy()`

Unsubscribes from the `CallCompleted` event to prevent memory leaks.

### QueueCall
`public void QueueCall(PhoneCallData data)`

Sets the `QueuedCallData` property, effectively queueing up a phone call to be made.

-   **Parameters:**
    -   `data`: The `PhoneCallData` scriptable object representing the call to be made.

### ClearQueuedCall
`public void ClearQueuedCall()`

Clears the currently queued call by setting `QueuedCallData` to `null`.

### CallCompleted
`private void CallCompleted(PhoneCallData call)`

An event handler that is called when the `CallInterface` finishes a call. If the completed call is the one that was queued, it clears the queue.

-   **Parameters:**
    -   `call`: The `PhoneCallData` of the call that was just completed.
