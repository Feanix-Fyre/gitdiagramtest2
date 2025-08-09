# ACSelection<T>

Inherits from `MonoBehaviour` where `T` is an `Object`.

## Description

An abstract base class for creating a selection interface in the avatar customization menu. It dynamically creates buttons for each option and handles selection logic.

## Fields

-   **ButtonPrefab**: `GameObject`
    -   A prefab for the buttons that represent the options.
-   **PropertyIndex**: `int`
    -   An index used to identify the property this selection controls.
-   **Options**: `List<T>`
    -   A list of options of type `T` to be displayed.
-   **Nullable**: `bool`
    -   If true, the selection can be deselected, resulting in a null value.
-   **DefaultOptionIndex**: `int`
    -   The index of the option that is selected by default.
-   **buttons**: `protected List<GameObject>`
    -   A list of the instantiated button game objects.
-   **SelectedOptionIndex**: `protected int`
    -   The index of the currently selected option. -1 if no option is selected.
-   **onValueChange**: `UnityEvent<T>`
    -   An event that is invoked when the selected value changes.
-   **onValueChangeWithIndex**: `UnityEvent<T, int>`
    -   An event that is invoked when the selected value changes, passing both the value and the `PropertyIndex`.

## Methods

### Awake
`protected virtual void Awake()`

Initializes the selection interface by instantiating a button for each option and setting up their labels and click listeners.

### SelectOption
`public void SelectOption(int index, bool notify = true)`

Selects an option by its index. If the option is already selected and `Nullable` is true, it deselects it.

-   **Parameters:**
    -   `index`: The index of the option to select.
    -   `notify`: If true, invokes the value change events.

### SetButtonHighlighted
`private void SetButtonHighlighted(int buttonIndex, bool h)`

Sets the highlighted state of a button's indicator.

-   **Parameters:**
    -   `buttonIndex`: The index of the button.
    -   `h`: The highlighted state.

## Abstract Methods

### CallValueChange
`public abstract void CallValueChange()`

An abstract method that must be implemented by derived classes to invoke the value change events.

### GetOptionLabel
`public abstract string GetOptionLabel(int index)`

An abstract method that must be implemented by derived classes to provide the display label for an option.

### GetAssetPathIndex
`public abstract int GetAssetPathIndex(string path)`

An abstract method that must be implemented by derived classes to find an option's index by its asset path.
