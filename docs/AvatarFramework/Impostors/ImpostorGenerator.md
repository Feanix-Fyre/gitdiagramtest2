# ImpostorGenerator

Inherits from `MonoBehaviour`.

## Description

A utility class designed to generate impostor textures for avatars. It uses a dedicated camera (`ImpostorCamera`) to render an `Avatar` with specific `AvatarSettings` to a `Texture2D`. This is likely used in an editor context to pre-generate textures for performance optimization.

## Fields

-   **ImpostorCamera**: `Camera`
    -   The camera used to render the avatar to a texture.
-   **Avatar**: `Avatar`
    -   A reference to the avatar model that will be rendered.
-   **GenerationQueue**: `List<AvatarSettings>`
    -   A list of `AvatarSettings` to be processed. The generator would iterate through this queue, apply each setting to the `Avatar`, and render a new impostor texture.
-   **output**: `[SerializeField] private Texture2D`
    -   A private field to hold the generated `Texture2D` output, exposed to the Unity Inspector.
