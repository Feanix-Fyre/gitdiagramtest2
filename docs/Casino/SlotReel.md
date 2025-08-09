# SlotReel

Inherits from `MonoBehaviour`.

## Description

This class controls a single reel of a `SlotMachine`. It handles the visual spinning of the reel and stopping it at a specific symbol.

## Inner Classes

### SymbolRotation (Serializable Class)
A simple class to map a `SlotMachine.ESymbol` to a specific rotation value (in degrees).
-   **Symbol**: `SlotMachine.ESymbol`
-   **Rotation**: `float`

## Fields

-   **SymbolRotations**: `SymbolRotation[]` - An array that defines the target rotation for each possible symbol on the reel.
-   **SpinSpeed**: `float` - The speed at which the reel rotates when spinning, in degrees per second.
-   **StopSound**: `AudioSourceController` - The sound effect to play when the reel comes to a stop.
-   **onStart**: `UnityEvent` - An event invoked when the reel starts spinning.
-   **onStop**: `UnityEvent` - An event invoked when the reel stops.

## Properties

-   **IsSpinning**: `bool` (read-only) - True if the reel is currently spinning.
-   **CurrentSymbol**: `SlotMachine.ESymbol` (read-only) - The symbol the reel is currently showing or will stop on.
-   **CurrentRotation**: `float` (read-only) - The current local rotation of the reel around its X-axis.

## Methods

### Update
`private void Update()`

Continuously updates the reel's rotation. If `IsSpinning` is true, it increments the rotation by `SpinSpeed`. If false, it ensures the reel's rotation is set to the correct angle for the `CurrentSymbol`.

### Spin
`public void Spin()`

Starts the spinning of the reel by setting `IsSpinning` to true and invoking the `onStart` event.

### Stop
`public void Stop(SlotMachine.ESymbol endSymbol)`

Stops the reel at a specific symbol. It sets `IsSpinning` to false, updates the `CurrentSymbol`, plays the `StopSound`, and invokes the `onStop` event.

-   **Parameters:**
    -   `endSymbol`: The `SlotMachine.ESymbol` that the reel should display when it stops.

### SetSymbol
`public void SetSymbol(SlotMachine.ESymbol symbol)`

Immediately sets the `CurrentSymbol` without affecting the spinning state.

-   **Parameters:**
    -   `symbol`: The symbol to set.
