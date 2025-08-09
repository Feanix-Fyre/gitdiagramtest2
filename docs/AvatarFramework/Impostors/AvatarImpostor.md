# AvatarImpostor

Inherits from `MonoBehaviour`.

## Description

This class represents an "impostor" for an avatar. An impostor is a simple, 2D billboard representation of a 3D model, used to save performance when the avatar is far away. This script handles applying the impostor texture and ensuring the billboard always faces the camera.

## Fields

-   **meshRenderer**: `MeshRenderer`
    -   The `MeshRenderer` component of the impostor's quad/plane.
-   **HasTexture**: `bool` (read-only)
    -   True if a valid impostor texture has been applied to the material.

## Properties

-   **Camera**: `Transform`
    -   A cached reference to the main player camera's transform.

## Methods

### SetAvatarSettings
`public void SetAvatarSettings(AvatarSettings settings)`

Applies the impostor texture from a given `AvatarSettings` object to the `meshRenderer`'s material.

-   **Parameters:**
    -   `settings`: The avatar settings containing the impostor texture.

### LateUpdate
`private void LateUpdate()`

Calls `Realign()` every frame to ensure the impostor always faces the camera.

### Realign
`private void Realign()`

Calculates the rotation needed to make the impostor's transform look at the camera's position (ignoring the Y-axis difference) and applies it. This creates the billboard effect.

### EnableImpostor
`public void EnableImpostor()`

Activates the impostor's game object and realigns it to the camera.

### DisableImpostor
`public void DisableImpostor()`

Deactivates the impostor's game object.
