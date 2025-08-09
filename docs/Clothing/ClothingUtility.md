# ClothingUtility

Inherits from `Singleton<ClothingUtility>`.

## Description

A singleton utility class that serves as a central database for clothing-related data. It holds lists that map `EClothingColor` and `EClothingSlot` enums to more detailed data, such as `UnityEngine.Color` values, names, and icons.

## Inner Classes

### ColorData (Serializable Class)
Maps an `EClothingColor` enum to its render color and a separate color for UI labels.
-   **ColorType**: `EClothingColor` - The enum key.
-   **ActualColor**: `Color` - The color used for rendering the item.
-   **LabelColor**: `Color` - The color used for UI text.

### ClothingSlotData (Serializable Class)
Maps an `EClothingSlot` enum to its display name and UI icon.
-   **Slot**: `EClothingSlot` - The enum key.
-   **Name**: `string` - The display name for the slot.
-   **Icon**: `Sprite` - The UI icon for the slot.

## Fields

-   **ColorDataList**: `List<ColorData>`
    -   The master list of all color data, editable in the Inspector.
-   **ClothingSlotDataList**: `List<ClothingSlotData>`
    -   The master list of all clothing slot data, editable in the Inspector.

## Methods

### OnValidate
`private void OnValidate()`

A Unity editor-only method that runs when the script is loaded or a value is changed in the Inspector. It automatically populates the `ColorDataList` and `ClothingSlotDataList` with default entries for any enum values that are missing, preventing data gaps.

### GetColorData
`public ColorData GetColorData(EClothingColor color)`

Retrieves the `ColorData` object for a given `EClothingColor`.

-   **Parameters:**
    -   `color`: The `EClothingColor` to look up.
-   **Returns:** The corresponding `ColorData` object, or `null` if not found.

### GetSlotData
`public ClothingSlotData GetSlotData(EClothingSlot slot)`

Retrieves the `ClothingSlotData` object for a given `EClothingSlot`.

-   **Parameters:**
    -   `slot`: The `EClothingSlot` to look up.
-   **Returns:** The corresponding `ClothingSlotData` object, or `null` if not found.
