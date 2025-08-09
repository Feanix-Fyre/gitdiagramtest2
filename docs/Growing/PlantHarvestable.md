# PlantHarvestable

Inherits from `MonoBehaviour`.

## Description

This component is attached to the individual harvestable parts of a plant model (e.g., the buds on a weed plant). It defines what product is given to the player when this part is harvested.

## Fields

-   **Product**: `StorableItemDefinition`
    -   The `ItemDefinition` of the item that is yielded when this part is harvested.
-   **ProductQuantity**: `int`
    -   The amount of the `Product` that is given to the player.

## Methods

### Harvest
`public virtual void Harvest(bool giveProduct = true)`

This method is called when the player harvests this specific part of the plant, typically triggered by the `HarvestPlant` player task. It performs the following actions:
1.  If `giveProduct` is true:
    -   It calls `GetHarvestedProduct` on the parent `Plant` to create the item instance.
    -   If the product is a new discovery, it registers it with the `ProductManager`.
    -   It adds the newly created item to the player's inventory.
2.  It sends a network message via the parent `Pot` to deactivate this harvestable site, so it cannot be harvested again.
3.  It creates a temporary, visual-only copy of the harvested part, gives it a `Rigidbody`, and flings it into the air for a nice visual effect before destroying it.
