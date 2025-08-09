# Cutscene

Requires a `UnityEngine.Animation` component.

## Description

This class represents a single cutscene. It controls the playback of an animation, takes over the player's camera, and can disable player controls for the duration of the cutscene.

## Fields

-   **Name**: `string`
    -   The name of the cutscene, used for logging.
-   **DisablePlayerControl**: `bool`
    -   If true, player movement and inventory will be disabled during the cutscene.
-   **OverrideFOV**: `bool`
    -   If true, the camera's Field of View will be set to `CameraFOV`.
-   **CameraFOV**: `float`
    -   The Field of View to use if `OverrideFOV` is true.
-   **CameraControl**: `Transform`
    -   A transform (likely animated) that the player's camera will be locked to during the cutscene.
-   **onPlay**: `UnityEvent`
    -   An event invoked when the cutscene begins playing.
-   **onEnd**: `UnityEvent`
    -   An event invoked when the cutscene ends (via `InvokeEnd`).

## Properties

-   **IsPlaying**: `bool` (read-only)
    -   True if the cutscene is currently playing.

## Methods

### LateUpdate
`private void LateUpdate()`

If the cutscene is playing, this method continuously forces the player's camera position and rotation to match the `CameraControl` transform every frame.

### Play
`public virtual void Play()`

Starts the cutscene. This method:
1.  Plays the associated `Animation` component.
2.  Sets `IsPlaying` to true.
3.  Invokes the `onPlay` event.
4.  Takes control of the player's camera, disabling the regular HUD.
5.  Optionally disables player controls and overrides the camera FOV.

### InvokeEnd
`public void InvokeEnd()`

Ends the cutscene. This method is typically called by an animation event on the last frame of the cutscene animation. It:
1.  Stops the animation.
2.  Sets `IsPlaying` to false.
3.  Invokes the `onEnd` event.
4.  Restores player control, re-enables the HUD, and releases control of the player's camera.
