# PlantGrowthStage

Inherits from `MonoBehaviour`.

## Description

This class represents a single visual stage in a `Plant`'s life cycle. It is essentially a container for a GameObject that holds the 3D model for that stage. The `Plant` class enables and disables these `PlantGrowthStage` GameObjects to show the plant growing over time.

## Fields

-   **GrowthSites**: `Transform[]`
    -   An array of transforms marking the locations where harvestable items (like buds or fruit) can appear. This is only used on the final growth stage of a plant.
