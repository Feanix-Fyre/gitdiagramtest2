# ColorFeature

Inherits from `Feature`.

## Description

This class implements a "feature" that allows a `Constructable` object to have its color changed. It manages a list of available colors, tracks the currently selected color, and applies it to a list of target `MeshRenderer`s.

## Inner Classes

### NamedColor (Serializable Class)
Represents a single color option available for purchase.
-   **colorName**: `string` - The display name of the color.
-   **color**: `Color` - The actual `UnityEngine.Color` value.
-   **price**: `float` - The cost to purchase this color option.

### SecondaryPaintTarget (Serializable Class)
Defines a set of renderers that should be painted with a modified version of the main color.
-   **colorTargets**: `List<MeshRenderer>` - The list of renderers to apply the modified color to.
-   **sChange**: `float` - The amount to change the color's saturation (in HSV).
-   **vChange**: `float` - The amount to change the color's value/brightness (in HSV).

## Fields

-   **colorTargets**: `List<MeshRenderer>` - The primary list of renderers that will be painted with the selected color.
-   **secondaryTargets**: `List<SecondaryPaintTarget>` - A list of targets to be painted with modified colors.
-   **colors**: `List<NamedColor>` - The list of all available color options for this feature.
-   **defaultColorIndex**: `int` - The index of the color that should be applied by default.

## `SyncVar`s

-   **ownedColorIndex**: `int` - The index of the currently selected/owned color. This is synchronized across the network.

## Methods

### CreateInterface
`public override FI_Base CreateInterface(Transform parent)`

Overrides the base method to create a `FI_ColorPicker` UI element. It hooks up the `ApplyColor` and `BuyColor` methods to the UI events.

### Default
`public override void Default()`

Applies the default color by calling `BuyColor` with the `defaultColorIndex`.

### ApplyColor
`private void ApplyColor(NamedColor color)`

Applies the selected `color` to all `colorTargets`. It also iterates through any `secondaryTargets` and applies a modified version of the color to them.

### ModifyColor
`public static Color ModifyColor(Color original, float sChange, float vChange)`

A static helper method that takes a color and modifies its saturation and value in HSV color space.

### BuyColor
`private void BuyColor(NamedColor color)`

Initiates the process of changing the color by calling the `SetData` `ServerRpc` with the index of the selected color.
