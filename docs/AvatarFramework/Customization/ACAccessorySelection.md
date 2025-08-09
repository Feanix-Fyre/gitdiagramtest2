# ACAccessorySelection

The `ACAccessorySelection` class is a component used in the avatar customization system for selecting accessories. It inherits from the generic `ACSelection<Accessory>` class.

## Methods

### `GetOptionLabel(int index)`

Gets the label for an accessory option at a specific index.

-   **Parameters:**
    -   `index`: The index of the option.
-   **Returns:** The name of the accessory.

### `CallValueChange()`

This method is called when the selected accessory changes. It invokes the `onValueChange` and `onValueChangeWithIndex` events with the newly selected accessory.

### `GetAssetPathIndex(string path)`

Gets the index of an accessory option based on its asset path.

-   **Parameters:**
    -   `path`: The asset path of the accessory.
-   **Returns:** The index of the accessory, or -1 if not found.
