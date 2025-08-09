# VialCap

Inherits from `Clickable`.

## Description

This class represents the cap on a seed vial. It is designed to be "clicked" by the player, which causes it to pop off the vial and become a dynamic physics object before being destroyed.

## Fields

-   **Collider**: `Collider`
    -   A reference to the cap's main collider.
-   **RigidBody**: `private Rigidbody`
    -   A reference to the Rigidbody component, which is added at runtime.

## Properties

-   **Removed**: `bool` (read-only)
    -   True if the cap has been popped off the vial.

## Methods

### StartClick
`public override void StartClick(RaycastHit hit)`

Overrides the base `StartClick` method. When the player clicks on the cap, it calls `Pop()`.

### Pop
`private void Pop()`

This method handles the logic for making the cap "pop" off.
1.  It adds a `Rigidbody` component to the cap's GameObject.
2.  It un-parents the cap from the vial.
3.  It disables its main `Collider` (likely to prevent it from immediately re-colliding with the vial).
4.  It applies forces and torque to the new `Rigidbody` to send it flying off.
5.  It schedules the cap's GameObject to be destroyed after 3 seconds.
6.  It disables this component.
