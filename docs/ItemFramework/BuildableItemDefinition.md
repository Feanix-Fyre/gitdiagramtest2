# BuildableItemDefinition

Inherits from `StorableItemDefinition`.

## Description

A `ScriptableObject` that defines an item that can be built or placed in the world. It links the inventory item to the `BuildableItem` prefab that represents the object in the game world.

## Enums

### EBuildSoundType
Defines the type of sound to play when the item is placed.
-   `Cardboard`
-   `Wood`
-   `Metal`

## Fields

-   **BuiltItem**: `BuildableItem`
    -   A reference to the prefab that will be instantiated when this item is built. This prefab must have a `BuildableItem` (or derived) component.
-   **BuildSoundType**: `EBuildSoundType`
    -   The type of sound that should be played when this item is successfully placed. This is used by the `BuildManager`.
