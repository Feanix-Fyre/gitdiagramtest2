# ClothingColorExtensions

A static class containing extension methods for the `EClothingColor` enum.

## Description

This class provides helper methods to convert an `EClothingColor` enum value into its corresponding `UnityEngine.Color` or string label. It relies on the `ClothingUtility` singleton to retrieve the color data.

## Methods

### GetActualColor
`public static Color GetActualColor(this EClothingColor color)`

Gets the actual `UnityEngine.Color` value used for rendering the clothing item.

-   **Parameters:**
    -   `color`: The `EClothingColor` enum value.
-   **Returns:** The `Color` struct associated with the enum value.

### GetLabelColor
`public static Color GetLabelColor(this EClothingColor color)`

Gets the `UnityEngine.Color` value used for displaying the color in UI labels.

-   **Parameters:**
    -   `color`: The `EClothingColor` enum value.
-   **Returns:** The UI label `Color` associated with the enum value.

### GetLabel
`public static string GetLabel(this EClothingColor color)`

Gets the string representation of the enum value.

-   **Parameters:**
    -   `color`: The `EClothingColor` enum value.
-   **Returns:** The name of the enum value as a string (e.g., "White").

### GetClothingColor
`public static EClothingColor GetClothingColor(Color color)`

Performs a reverse lookup, finding the `EClothingColor` enum value that most closely matches a given `UnityEngine.Color`.

-   **Parameters:**
    -   `color`: The `Color` to find a match for.
-   **Returns:** The matching `EClothingColor`, or `EClothingColor.White` if no close match is found.

### ColorEquals
`public static bool ColorEquals(Color a, Color b, float tolerance = 0.004f)`

Compares two `Color` structs to see if they are approximately equal within a given tolerance.

-   **Parameters:**
    -   `a`: The first color.
    -   `b`: The second color.
    -   `tolerance`: The maximum allowed difference for each color channel (r, g, b).
-   **Returns:** `true` if the colors are within the tolerance, otherwise `false`.
