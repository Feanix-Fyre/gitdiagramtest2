# Feature

Inherits from `NetworkBehaviour`.

## Description

An abstract base class for all "features" that can be attached to a `Constructable` object. A feature represents a customizable aspect of an object, such as its color, material, or a specific option. Each feature is responsible for creating its own UI and handling its own data synchronization.

## Fields

-   **featureName**: `string`
    -   The display name of the feature (e.g., "Paint Color", "Wood Type").
-   **featureIcon**: `Sprite`
    -   The icon used to represent this feature in the construction UI.
-   **featureIconLocation**: `Transform`
    -   A transform in the world where the feature's icon should appear as a world-space UI element.
-   **featureInterfacePrefab**: `GameObject`
    -   A prefab for the UI panel that will be instantiated to control this feature's settings.
-   **disableRoofDisibility**: `bool`
    -   A flag to control roof visibility behavior (the exact effect is not detailed in this class).

## Methods

### CreateInterface
`public virtual FI_Base CreateInterface(Transform parent)`

A virtual method responsible for creating the UI for this feature. It instantiates the `featureInterfacePrefab`, gets its `FI_Base` component (Feature Interface), and initializes it.

-   **Parameters:**
    -   `parent`: The parent transform to instantiate the UI under.
-   **Returns:** The `FI_Base` component of the newly created UI.

### Default
`public abstract void Default()`

An abstract method that must be implemented by derived classes. This method is called to apply the default state or setting for this feature (e.g., applying the default color).
