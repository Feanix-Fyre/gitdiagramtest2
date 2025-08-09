# ConstructStart_Base

Inherits from `MonoBehaviour`.

## Description

An abstract base class for scripts that handle the beginning of a construction process (placing a new item or moving an existing one). This component is expected to be on a "Construction Handler" prefab.

## Methods

### StartConstruction
`public virtual void StartConstruction(string constructableID, Constructable_GridBased movedConstructable = null)`

A virtual method called by the `ConstructionManager` when a construction or move process is initiated.

Its base implementation handles the logic for moving an existing object:
-   It assigns the `movedConstructable` to the `MovedConstructable` property on the `ConstructUpdate_Base` component.
-   It makes the original `movedConstructable` invisible while the ghost model is being positioned.

-   **Parameters:**
    -   `constructableID`: The ID of the item being built or moved.
    -   `movedConstructable`: If moving an existing object, this is a reference to it. Otherwise, it is `null`.
