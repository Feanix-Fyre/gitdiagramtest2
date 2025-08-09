# AdditiveDefinition

Inherits from `StorableItemDefinition`.

## Description

A `ScriptableObject` that defines an "additive" item (like fertilizer). It links the inventory item definition to the functional `Additive` prefab that contains the logic for how the additive affects a plant.

## Fields

-   **AdditivePrefab**: `Additive`
    -   A reference to the prefab that contains the `Additive` component. This prefab holds the actual gameplay values for the additive (e.g., `QualityChange`, `GrowSpeedMultiplier`).
