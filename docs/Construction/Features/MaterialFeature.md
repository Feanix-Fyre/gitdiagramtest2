# MaterialFeature

Inherits from `OptionListFeature`.

## Description

This class implements a feature that allows the material of a `Constructable` object to be changed. It manages a list of available materials and applies the selected one to a list of target `MeshRenderer`s.

## Inner Classes

### NamedMaterial (Serializable Class)
Represents a single material option available for purchase.
-   **matName**: `string` - The display name of the material.
-   **buttonColor**: `Color` - A color used for this option's button in the UI.
-   **mat**: `Material` - The actual `Material` asset.
-   **price**: `float` - The cost to purchase this material option.

## Fields

-   **materialTargets**: `List<MeshRenderer>`
    -   The list of `MeshRenderer`s that will have their material changed.
-   **materials**: `List<NamedMaterial>`
    -   The list of all available material options for this feature.

## Methods

### SelectOption
`public override void SelectOption(int optionIndex)`

Overrides the base method. It is called when the player selects a material option in the UI. It calls `ApplyMaterial` to update the object's appearance for preview.

-   **Parameters:**
    -   `optionIndex`: The index of the material to apply.

### ApplyMaterial
`private void ApplyMaterial(NamedMaterial mat)`

Applies the selected `NamedMaterial`'s `mat` property to all `MeshRenderer`s in the `materialTargets` list.

-   **Parameters:**
    -   `mat`: The `NamedMaterial` to apply.

### GetOptions
`protected override List<FI_OptionList.Option> GetOptions()`

Overrides the base method to build a list of `FI_OptionList.Option` data structures from the `materials` list. This data is used to populate the UI for this feature.

-   **Returns:** A list of UI-friendly option data.
