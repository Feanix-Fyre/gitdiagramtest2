# Constructable

Inherits from `NetworkBehaviour`.

## Description

A base class for all objects in the world that are built by the player. It contains common properties like name, description, and asset paths, as well as core functionality for being destroyed, selected, and outlined.

## Key Properties

-   **IsStatic**: `bool` (read-only) - If true, this object cannot be moved or destroyed.
-   **ConstructableName**: `string` (read-only) - The display name of the object.
-   **ConstructableDescription**: `string` (read-only) - The UI description for the object.
-   **ConstructableAssetPath**: `string` (read-only) - The asset path used to instantiate this object.
-   **ConstructableIcon**: `Sprite` (read-only) - The UI icon for this object.
-   **boundingBox**: `BoxCollider` - The main bounding box for the object.
-   **features**: `List<Feature>` - A list of feature components that add extra functionality (e.g., color options, material choices).

## Methods

### CanBeDestroyed
`public virtual bool CanBeDestroyed(out string reason)`

Checks if the object can be destroyed. By default, this is true if `isStatic` is false.

-   **Parameters:**
    -   `reason`: An `out` parameter to explain why it cannot be destroyed.
-   **Returns:** `true` if the object can be destroyed.

### DestroyConstructable
`public virtual void DestroyConstructable(bool callOnServer = true)`

Destroys the constructable object. If `callOnServer` is true, it sends an RPC to the server to despawn the object across the network. It also deactivates the local GameObject.

### CanBeModified
`public virtual bool CanBeModified()`

Checks if the object can be modified by the construction system. Default is `true`.

### CanBeSelected
`public virtual bool CanBeSelected()`

Checks if the object can be selected by the construction system. Default is `true` unless `isStatic` is true.

### ShowOutline / HideOutline
`public void ShowOutline(BuildableItem.EOutlineColor color)` and `public void HideOutline()`

These methods control a visual outline effect on the object, typically used when the player is hovering over it in construction mode. `ShowOutline` adds and configures an `Outlinable` component, while `HideOutline` disables it.

### SetInvisible / RestoreVisibility
`public virtual void SetInvisible()` and `public virtual void RestoreVisibility()`

Methods to hide the object by setting its layer to "Invisible" and to restore its original layers. This is used to temporarily hide objects, for example, when the player camera is clipping through them.
