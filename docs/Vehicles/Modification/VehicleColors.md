# VehicleColors

The `VehicleColors` class is a singleton that holds a library of `VehicleColorData`. It provides methods to get the name and UI color for a given `EVehicleColor`.

## Classes

### VehicleColorData

This class is a data container for a single vehicle color.

-   `color`: The `EVehicleColor` that this data represents.
-   `colorName`: The name of the color.
-   `material`: The material to use for this color.
-   `UIColor`: The color to use in the UI for this color.

## Properties

-   `colorLibrary`: A list of `VehicleColorData` that make up the color library.

## Methods

-   `GetColorName(EVehicleColor c)`: Gets the name of the specified color.
-   `GetColorUIColor(EVehicleColor c)`: Gets the UI color of the specified color.
