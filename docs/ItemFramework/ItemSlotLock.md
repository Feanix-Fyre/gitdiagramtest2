# ItemSlotLock

A class that represents a lock on an `ItemSlot`.

## Description

When an `ItemSlot` needs to be temporarily non-interactable (e.g., during a crafting process), an instance of this class is created and assigned to the slot's `ActiveLock` property. This lock contains information about which object owns the lock and for what reason.

## Properties

-   **Slot**: `ItemSlot` (read-only)
    -   The `ItemSlot` that this lock applies to.
-   **LockOwner**: `NetworkObject` (read-only)
    -   The `NetworkObject` that initiated the lock.
-   **LockReason**: `string` (read-only)
    -   A string describing the reason for the lock, which can be used for UI or debugging purposes.

## Constructors

### ItemSlotLock(ItemSlot slot, NetworkObject lockOwner, string lockReason)
Creates a new lock for a given slot.

-   **Parameters:**
    -   `slot`: The slot to be locked.
    -   `lockOwner`: The object that is locking the slot.
    -   `lockReason`: The reason for the lock.
