# ItemQuality

A static class containing constants and helper methods related to item quality.

## Description

This class provides a centralized place to define the thresholds for different quality levels and their associated UI colors. It allows for easy conversion from a normalized float value (0.0 to 1.0) to an `EQuality` enum and its corresponding color.

## Constants & Static Fields

-   **Thresholds**: `float` constants (`Heavenly_Threshold`, `Premium_Threshold`, etc.) define the minimum normalized value required to achieve that quality level.
-   **Colors**: `static Color` fields (`Heavenly_Color`, `Premium_Color`, etc.) define the UI color associated with each quality level.

## Methods

### GetQuality
`public static EQuality GetQuality(float qualityScalar)`

Converts a normalized quality value (from 0.0 to 1.0) into its corresponding `EQuality` enum.

-   **Parameters:**
    -   `qualityScalar`: The normalized quality value.
-   **Returns:** The appropriate `EQuality` enum.

### GetColor
`public static Color GetColor(EQuality quality)`

Gets the UI display color for a given `EQuality` enum.

-   **Parameters:**
    -   `quality`: The `EQuality` to get the color for.
-   **Returns:** The `Color` associated with the quality level.
