# ACAvatarLayerSelection

Inherits from `ACSelection<AvatarLayer>`.

## Description

This class manages the selection of `AvatarLayer` options in the character customization interface. It provides methods to get option labels, handle value changes, and find the index of an asset by its path.

## Methods

### GetOptionLabel
`public override string GetOptionLabel(int index)`

Gets the display label for a given option index.

-   **Parameters:**
    -   `index`: The index of the option.
-   **Returns:** The name of the `AvatarLayer` at the specified index.

### CallValueChange
`public override void CallValueChange()`

Invokes the `onValueChange` and `onValueChangeWithIndex` events when the selected option changes. It passes the selected `AvatarLayer` or `null` if no option is selected.

### GetAssetPathIndex
`public override int GetAssetPathIndex(string path)`

Finds the index of an `AvatarLayer` in the options list based on its asset path.

-   **Parameters:**
    -   `path`: The asset path of the `AvatarLayer`.
-   **Returns:** The index of the `AvatarLayer` if found; otherwise, -1.
