# GenericOption

Inherits from `MonoBehaviour`.

## Description

This class represents a single, selectable option within a `GenericOptionListFeature`. For example, if a feature lets you choose between different types of windows, each window style would be a `GenericOption`. It uses `UnityEvent`s to trigger actions when the option is installed, uninstalled, or has its visibility changed.

## Fields

-   **optionName**: `string`
    -   The display name for this option in the UI.
-   **optionButtonColor**: `Color`
    -   A color used for this option's button in the UI.
-   **optionPrice**: `float`
    -   The cost to purchase or install this option.
-   **onInstalled**: `UnityEvent`
    -   An event invoked when this option is installed. Can be configured in the Inspector to enable/disable GameObjects, change materials, etc.
-   **onUninstalled**: `UnityEvent`
    -   An event invoked when this option is uninstalled (i.e., another option is chosen).
-   **onSetVisible**: `UnityEvent`
    -   An event invoked to make the visual components of this option visible.
-   **onSetInvisible**: `UnityEvent`
    -   An event invoked to make the visual components of this option invisible.

## Methods

### Install
`public virtual void Install()`

Calls the `onInstalled` event and then calls `SetVisible()`.

### Uninstall
`public virtual void Uninstall()`

Calls the `onUninstalled` event and then calls `SetInvisible()`.

### SetVisible
`public virtual void SetVisible()`

Calls the `onSetVisible` event.

### SetInvisible
`public virtual void SetInvisible()`

Calls the `onSetInvisible` event.
