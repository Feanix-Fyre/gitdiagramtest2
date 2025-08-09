# RockerSwitch

Inherits from `MonoBehaviour`.

## Description

This class controls a simple rocker switch. It manages the visual state of the switch (the angle of the button) and can toggle an associated `Light` component on and off.

## Fields

-   **ButtonMesh**: `MeshRenderer`
    -   A reference to the mesh renderer of the switch's button. (Note: This field is declared but not used in the provided code).
-   **ButtonTransform**: `Transform`
    -   A reference to the transform of the button part of the switch. This is rotated to show the on/off state.
-   **Light**: `Light`
    -   A reference to the `Light` component that this switch controls.
-   **isOn**: `bool`
    -   The current state of the switch.

## Methods

### Awake
`private void Awake()`

Initializes the switch by calling `SetIsOn` with the initial value of the `isOn` field.

### SetIsOn
`public void SetIsOn(bool on)`

Sets the state of the switch.
-   It updates the `isOn` field.
-   It enables or disables the associated `Light`.
-   It rotates the `ButtonTransform` to visually represent the on or off state.

-   **Parameters:**
    -   `on`: The new state for the switch. `true` for on, `false` for off.
