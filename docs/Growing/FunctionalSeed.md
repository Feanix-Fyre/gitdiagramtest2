# FunctionalSeed

Inherits from `MonoBehaviour`.

## Description

This class represents the functional, physical prefab of a seed that can be planted. It contains references to the different parts of the seed vial model and is likely used in conjunction with the `SowSeedTask` to animate the process of taking a seed out of its container.

## Fields

-   **onSeedExitVial**: `Action`
    -   An event that is invoked when the seed's collider exits the vial's trigger volume.
-   **Vial**: `Draggable`
    -   A reference to the `Draggable` component on the vial part of the model.
-   **SeedBlocker**: `Collider`
    -   A collider that likely blocks the seed from falling out until the cap is removed.
-   **Cap**: `VialCap`
    -   A reference to the `VialCap` component on the cap part of the model.
-   **SeedCollider**: `Collider`
    -   The main collider for the seed itself.
-   **SeedRigidbody**: `Rigidbody`
    -   The rigidbody for the seed itself.
-   **TrashPrefab**: `TrashItem`
    -   The prefab for the empty vial that is left behind after the seed is planted.

## Methods

### TriggerExit
`public void TriggerExit(Collider other)`

This method is likely called by a trigger volume on the vial. When the `SeedCollider` exits this trigger, it invokes the `onSeedExitVial` event, signaling that the seed has been successfully removed from its container.

-   **Parameters:**
    -   `other`: The collider that exited the trigger.
