# Registry

The `Registry` class is a persistent singleton that manages registries for game objects and items. It provides a centralized way to retrieve game object prefabs and item definitions using their unique IDs.

## Nested Classes

### `ObjectRegister`

Represents an entry in the object registry.

-   `ID`: The unique identifier for the object.
-   `AssetPath`: The path to the object's asset.
-   `Prefab`: The `NetworkObject` prefab.

### `ItemRegister`

Represents an entry in the item registry.

-   `ID`: The unique identifier for the item.
-   `AssetPath`: The path to the item's asset.
-   `Definition`: The `ItemDefinition` of the item.

## Properties

-   `Seeds`: A list of `SeedDefinition` items available in the game.

## Methods

### `GetPrefab(string id)`

Retrieves a game object prefab from the object registry by its ID.

-   **Parameters:**
    -   `id`: The ID of the prefab to retrieve.
-   **Returns:** The `GameObject` prefab, or `null` if not found.

### `GetItem(string ID)`

Retrieves an `ItemDefinition` from the item registry by its ID.

-   **Parameters:**
    -   `ID`: The ID of the item to retrieve.
-   **Returns:** The `ItemDefinition`, or `null` if not found.

### `ItemExists(string ID)`

Checks if an item with the specified ID exists in the registry.

-   **Parameters:**
    -   `ID`: The ID of the item to check.
-   **Returns:** `true` if the item exists, `false` otherwise.

### `GetItem<T>(string ID)`

Retrieves an `ItemDefinition` of a specific type `T` from the item registry by its ID.

-   **Parameters:**
    -   `ID`: The ID of the item to retrieve.
-   **Returns:** The `ItemDefinition` cast to type `T`, or `null` if not found.

### `GetConstructable(string id)`

Retrieves a `Constructable` component from a prefab in the object registry.

-   **Parameters:**
    -   `id`: The ID of the constructable object.
-   **Returns:** The `Constructable` component, or `null` if not found.

### `AddToRegistry(ItemDefinition item)`

Adds an item to the registry at runtime.

-   **Parameters:**
    -   `item`: The `ItemDefinition` to add.

### `RemoveFromRegistry(ItemDefinition item)`

Removes a runtime-added item from the registry.

-   **Parameters:**
    -   `item`: The `ItemDefinition` to remove.

### `LogOrderedUnlocks()`

Logs a list of all unlockable items, ordered by their required rank.
