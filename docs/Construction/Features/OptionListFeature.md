# OptionListFeature

Inherits from `Feature`.

## Description

An abstract base class for any feature that presents the player with a list of options to choose from (e.g., different materials, different window styles). It handles the creation of the list-based UI and synchronizes the index of the chosen option.

## Fields

-   **defaultOptionIndex**: `int`
    -   The index of the option that should be applied by default.

## `SyncVar`s

-   **ownedOptionIndex**: `int`
    -   The index of the currently selected/owned option. This is synchronized across the network. When this value changes on a client, the `ReceiveData` method is called, which in turn calls `SelectOption`.

## Methods

### CreateInterface
`public override FI_Base CreateInterface(Transform parent)`

Overrides the base method to create an `FI_OptionList` UI element. It initializes the UI with the list of options returned by `GetOptions()` and hooks up the `SelectOption` and `PurchaseOption` methods to the UI events.

-   **Parameters:**
    -   `parent`: The parent transform to instantiate the UI under.
-   **Returns:** The `FI_OptionList` component of the newly created UI.

### Default
`public override void Default()`

Applies the default state for the feature by calling `PurchaseOption` for the `defaultOptionIndex`.

### GetOptions
`protected abstract List<FI_OptionList.Option> GetOptions()`

An abstract method that must be implemented by derived classes. This method should return a list of `FI_OptionList.Option` structs, which contain the data needed to display the options in the UI (name, color, price).

### SelectOption
`public virtual void SelectOption(int optionIndex)`

A virtual method called when the player selects an option in the UI for preview. Derived classes should override this to implement the logic for visually applying the selected option.

-   **Parameters:**
    -   `optionIndex`: The index of the selected option.

### PurchaseOption
`public virtual void PurchaseOption(int optionIndex)`

A virtual method called when the player confirms the purchase of an option. It calls the `SetData` `ServerRpc` to synchronize the new `ownedOptionIndex`.

-   **Parameters:**
    -   `optionIndex`: The index of the purchased option.
