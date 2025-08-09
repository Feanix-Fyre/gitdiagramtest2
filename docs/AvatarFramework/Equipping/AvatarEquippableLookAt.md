# AvatarEquippableLookAt

Inherits from `MonoBehaviour`. Requires an `AvatarEquippable` component on the same GameObject.

## Description

This component makes the avatar look at the equippable item it's attached to. It does this by overriding the avatar's look target in `LateUpdate`.

## Fields

-   **Priority**: `int`
    -   The priority of the look override. This is passed to the `AvatarLookController` to determine if this look request should take precedence over others.
-   **avatar**: `private Avatar`
    -   A reference to the `Avatar` component in the parent hierarchy.

## Methods

### Start
`private void Start()`

Initializes the component by getting a reference to the parent `Avatar`.

### LateUpdate
`private void LateUpdate()`

Each frame, this method calls `OverrideLookTarget` on the avatar's `LookController`, passing the position of the equippable item's transform. This ensures the avatar's head and eyes will track the item.
