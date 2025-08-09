# LightVisibilityAffector

The `LightVisibilityAffector` class is a MonoBehaviour that can be attached to a `Light` game object to make it affect the player's visibility. It calculates the visibility based on the light's type, range, intensity, and other factors, and then creates or updates a `VisibilityAttribute` on the player.

## Properties

-   `EffectMultiplier`: A multiplier for the effect of the light on the player's visibility.
-   `uniquenessCode`: A string that is used to create a `UniqueVisibilityAttribute`. If this is empty, a regular `VisibilityAttribute` will be created instead.
-   `updateDistanceThreshold`: The distance the player has to move before the visibility is recalculated.

## Methods

-   `UpdateVisibility()`: This method is called when the player moves more than the `updateDistanceThreshold`. It calculates the new visibility and updates the `VisibilityAttribute`.
-   `UpdateAttribute(float visibity)`: This method creates a new `VisibilityAttribute` or updates an existing one with the new visibility value.
-   `ClearAttribute()`: This method removes the `VisibilityAttribute` from the player.
