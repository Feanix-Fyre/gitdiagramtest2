# SeedDefinition

Inherits from `StorableItemDefinition`.

## Description

A `ScriptableObject` that defines a type of seed. It links the inventory item to the prefabs that are used when the seed is planted.

## Fields

-   **FunctionSeedPrefab**: `FunctionalSeed`
    -   A reference to the prefab that represents the physical seed and its container (e.g., a vial). This is instantiated during the `SowSeedTask`.
-   **PlantPrefab**: `Plant`
    -   A reference to the prefab for the `Plant` that will grow from this seed. This is instantiated inside a `Pot` after the seed is successfully sown.
