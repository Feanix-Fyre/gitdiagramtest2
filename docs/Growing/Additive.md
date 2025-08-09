# Additive

Inherits from `MonoBehaviour`.

## Description

This class defines the properties of an additive that can be applied to a plant, such as fertilizer or a chemical. It contains values that modify a plant's growth characteristics. This component is typically attached to a prefab representing the additive.

## Fields

-   **AdditiveName**: `string`
    -   The display name of the additive.
-   **AssetPath**: `string`
    -   The path to this additive's prefab in the project's Resources folder.
-   **QualityChange**: `float`
    -   The amount to change the plant's quality when this additive is applied.
-   **YieldChange**: `float`
    -   The amount to change the plant's final yield when this additive is applied.
-   **GrowSpeedMultiplier**: `float`
    -   A multiplier applied to the plant's growth speed. Values greater than 1 speed up growth, while values less than 1 slow it down.
-   **InstantGrowth**: `float`
    -   An amount of "growth" to be added instantly to the plant, effectively fast-forwarding its progress.
