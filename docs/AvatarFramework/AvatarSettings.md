# AvatarSettings

The `AvatarSettings` class is a `ScriptableObject` that stores all the settings for an avatar's appearance. This includes properties for skin color, height, gender, weight, hair, eyes, and various layers for face and body details.

## Nested Classes

### `LayerSetting`

A struct that defines a layer's asset path and tint color.

-   `layerPath`: The asset path of the layer.
-   `layerTint`: The color tint to apply to the layer.

### `AccessorySetting`

A class that defines an accessory's asset path and color.

-   `path`: The asset path of the accessory.
-   `color`: The color of the accessory.

## Properties

-   `SkinColor`: The color of the avatar's skin.
-   `Height`: The height of the avatar.
-   `Gender`: The gender of the avatar, represented as a float.
-   `Weight`: The weight of the avatar.
-   `HairPath`: The asset path for the avatar's hair.
-   `HairColor`: The color of the avatar's hair.
-   `EyebrowScale`: The scale of the eyebrows.
-   ...and many more properties for eye, eyelid, and layer settings.

## Methods

### `GetJson(bool prettyPrint = true)`

Serializes the `AvatarSettings` object to a JSON string.

-   **Parameters:**
    -   `prettyPrint`: Whether to format the JSON string for readability.
-   **Returns:** A JSON string representation of the object.
