# AvatarLayer

The `AvatarLayer` class is a `ScriptableObject` that defines a layer for an avatar's appearance, such as clothing, tattoos, or other details. These layers can be combined to create the final look of the avatar.

## Properties

-   `Name`: The name of the avatar layer.
-   `AssetPath`: The asset path of the layer.
-   `Texture`: The main texture for the layer.
-   `Normal`: The normal map texture for the layer.
-   `Normal_DefaultFormat`: The normal map texture in the default format.
-   `Order`: The rendering order of the layer. Lower numbers are rendered first.
-   `CombinedMaterial`: A material that can be used for a combined version of the layer.
