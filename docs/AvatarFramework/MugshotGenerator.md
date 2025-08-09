# MugshotGenerator

The `MugshotGenerator` class is a singleton that generates a mugshot image of an avatar based on a given `AvatarSettings` object. It uses an `IconGenerator` to capture the image and can either save it to a file or return it as a `Texture2D` via a callback.

## Properties

-   `OutputPath`: The path where the generated mugshot will be saved.
-   `Settings`: The `AvatarSettings` to use for generating the mugshot.
-   `MugshotRig`: A reference to the `Avatar` component used as a rig for generating the mugshot.
-   `Generator`: A reference to the `IconGenerator` used to capture the image.
-   `DefaultSettings`: The default `AvatarSettings` to apply to the rig when it's not in use.

## Methods

### `GenerateMugshot()`

Generates a mugshot using the `Settings` property and saves it to the `OutputPath`.

### `GenerateMugshot(AvatarSettings settings, bool fileToFile, Action<Texture2D> callback)`

Generates a mugshot from the given `AvatarSettings`.

-   **Parameters:**
    -   `settings`: The `AvatarSettings` to use for the mugshot.
    -   `fileToFile`: If `true`, the mugshot will be saved to a file.
    -   `callback`: An optional `Action<Texture2D>` that will be called with the generated texture.
