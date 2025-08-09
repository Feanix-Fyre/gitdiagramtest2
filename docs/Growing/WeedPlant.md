# WeedPlant

Inherits from `Plant`.

## Description

This class represents a specific type of plant: a Weed Plant. It extends the base `Plant` class to define what product is yielded upon harvest.

## Fields

-   **BranchPrefab**: `PlantHarvestable`
    -   A reference to the prefab for a harvestable branch of the plant. This contains the `ItemDefinition` for the product that is yielded.

## Methods

### GetHarvestedProduct
`public override ItemInstance GetHarvestedProduct(int quantity = 1)`

Overrides the base method to define the specific item yielded by a weed plant. It creates a new `QualityItemInstance` of the product defined in the `BranchPrefab` and sets its quality based on the plant's `QualityLevel`.

-   **Parameters:**
    -   `quantity`: The amount of product to create.
-   **Returns:** A new `ItemInstance` representing the harvested weed.
