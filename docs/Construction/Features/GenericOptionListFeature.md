# GenericOptionListFeature

Inherits from `OptionListFeature`.

## Description

This class provides a concrete implementation of `OptionListFeature` that works with a list of `GenericOption` components. It manages the selection and installation of these options, allowing for modular and interchangeable parts on a `Constructable` object.

## Fields

-   **options**: `List<GenericOption>`
    -   A list of all the `GenericOption` components that are available for this feature. These are typically child GameObjects of the feature itself.
-   **visibleOption**: `private GenericOption`
    -   A reference to the option that is currently being previewed (visible).
-   **installedOption**: `private GenericOption`
    -   A reference to the option that is currently purchased and installed.

## Methods

### Default
`public override void Default()`

Applies the default state for the feature. It first calls `Uninstall()` on all options to ensure a clean state, and then calls `PurchaseOption` for the `defaultOptionIndex`.

### GetOptions
`protected override List<FI_OptionList.Option> GetOptions()`

Overrides the base method to build a list of `FI_OptionList.Option` data structures from the `options` list. This data is used to populate the UI for this feature.

-   **Returns:** A list of UI-friendly option data.

### SelectOption
`public override void SelectOption(int optionIndex)`

Called when the player selects an option in the UI for preview. It makes the previously visible option invisible and makes the newly selected option visible.

-   **Parameters:**
    -   `optionIndex`: The index of the option to preview.

### PurchaseOption
`public override void PurchaseOption(int optionIndex)`

Called when the player confirms the purchase of an option. It uninstalls the previously installed option and installs the new one by calling the `Uninstall()` and `Install()` methods on the respective `GenericOption` components.

-   **Parameters:**
    -   `optionIndex`: The index of the option to install.
