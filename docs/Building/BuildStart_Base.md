# BuildStart_Base

Inherits from `MonoBehaviour`.

## Description

An abstract base class for scripts that handle the beginning of a build process. This component is expected to be on a "Build Handler" prefab.

## Methods

### StartBuilding
`public abstract void StartBuilding(ItemInstance item)`

An abstract method that must be implemented by derived classes. This method is called by the `BuildManager` when a build process is initiated.

-   **Parameters:**
    -   `item`: The `ItemInstance` that is being built.
