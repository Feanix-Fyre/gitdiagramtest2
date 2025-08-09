# BuildManager

Inherits from `Singleton<BuildManager>`.

## Description

The central manager for the player's building system. It handles the lifecycle of building objects, from initiating the build process with a "ghost" object to spawning the final, networked object in the world. It also provides a suite of utility methods for manipulating ghost objects.

## Inner Classes

### BuildSound
A serializable class to link a `BuildableItemDefinition.EBuildSoundType` to an `AudioSourceController`.
-   **Type**: `BuildableItemDefinition.EBuildSoundType`
-   **Sound**: `AudioSourceController`

## Fields

-   **PlaceSounds**: `List<BuildSound>` - A list mapping sound types to audio sources.
-   **networkObject**: `NetworkObject` - Reference to the local player's network object for spawning.
-   **ghostMaterial_White**: `Material` - The material for a valid ghost placement.
-   **ghostMaterial_Red**: `Material` - The material for an invalid ghost placement.
-   **isBuilding**: `bool` (read-only) - Is the player currently in build mode?
-   **currentBuildHandler**: `GameObject` (read-only) - The active build handler object.

## Methods

### StartBuilding
`public void StartBuilding(ItemInstance item)`

Starts the build process for a standard buildable item. It instantiates the item's specific `BuildHandler` prefab.

-   **Parameters:**
    -   `item`: The `ItemInstance` of the item to build. Must have a `BuildableItemDefinition`.

### StartBuildingStoredItem
`public void StartBuildingStoredItem(ItemInstance item)`

Starts the build process for placing a storable item (like a box or crate).

-   **Parameters:**
    -   `item`: The `ItemInstance` of the storable item.

### StartPlacingCash
`public void StartPlacingCash(ItemInstance item)`

Starts the process for placing a stack of cash in the world.

-   **Parameters:**
    -   `item`: The `ItemInstance` of the cash.

### StopBuilding
`public void StopBuilding()`

Stops the current build process, usually destroying the ghost object.

### PlayBuildSound
`public void PlayBuildSound(BuildableItemDefinition.EBuildSoundType type, Vector3 point)`

Plays a build-related sound at a specific world position.

### Ghost Object Utilities
The manager provides several public methods to prepare a "ghost" object (the transparent preview of the item being placed). These methods are called by build handlers to disable components that shouldn't be active on a ghost.
-   `DisableColliders(GameObject obj)`
-   `DisableLights(GameObject obj)`
-   `DisableNetworking(GameObject obj)`
-   `DisableSpriteRenderers(GameObject obj)`
-   `DisableNavigation(GameObject obj)`
-   `DisableCanvases(GameObject obj)`
-   `ApplyMaterial(GameObject obj, Material mat, bool allMaterials = true)`

### Object Creation Methods
These methods are called by build handlers when a placement is confirmed. They instantiate the final object, initialize it with the correct properties (grid position, rotation, etc.), and spawn it over the network.
-   `CreateGridItem(...)`
-   `CreateProceduralGridItem(...)`
-   `CreateSurfaceItem(...)`
-   `CreateStoredItem(...)`
