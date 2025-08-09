# CocaPlant

Inherits from `Plant`.

## Description

This class represents a specific type of plant: a Coca Plant. It extends the base `Plant` class to define what product is yielded upon harvest.

## Fields

-   **Harvestable**: `PlantHarvestable`
    -   A reference to the `PlantHarvestable` component on this plant, which contains information about the product to be yielded.

## Methods

### GetHarvestedProduct
`public override ItemInstance GetHarvestedProduct(int quantity = 1)`

Overrides the base method to define the specific item yielded by a coca plant. It creates a new `QualityItemInstance` of the product defined in the `Harvestable` component and sets its quality based on the plant's `QualityLevel`.

-   **Parameters:**
    -   `quantity`: The amount of product to create.
-   **Returns:** A new `ItemInstance` representing the harvested coca leaves.
