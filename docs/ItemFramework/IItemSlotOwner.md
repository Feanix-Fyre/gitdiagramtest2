# IItemSlotOwner

An interface for any object that owns a collection of `ItemSlot`s, such as a player's inventory or a storage container.

## Description

This interface defines the essential properties and methods required for an object to manage a list of item slots and synchronize their state over the network. It includes methods for setting item instances, quantities, and lock states, as well as helper methods for querying the contents.

## Properties

-   **ItemSlots**: `List<ItemSlot>`
    -   The list of `ItemSlot`s that this object owns.

## Methods

### SetStoredInstance
`void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)`

An abstract method that should be implemented as an RPC to set the `ItemInstance` of a specific slot and synchronize it to clients.

-   **Parameters:**
    -   `conn`: The network connection to send the update to (can be null for all).
    -   `itemSlotIndex`: The index of the slot to update.
    -   `instance`: The new `ItemInstance` for the slot.

### SetItemSlotQuantity
`void SetItemSlotQuantity(int itemSlotIndex, int quantity)`

An abstract method that should be implemented as an RPC to set the quantity of the item in a specific slot and synchronize it.

-   **Parameters:**
    -   `itemSlotIndex`: The index of the slot to update.
    -   `quantity`: The new quantity for the item in the slot.

### SetSlotLocked
`void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)`

An abstract method that should be implemented as an RPC to set the lock state of a specific slot and synchronize it.

-   **Parameters:**
    -   `conn`: The network connection to send the update to (can be null for all).
    -   `itemSlotIndex`: The index of the slot to update.
    -   `locked`: The new lock state.
    -   `lockOwner`: The `NetworkObject` that owns the lock.
    -   `lockReason`: The reason for the lock.

### SendItemsToClient (Default Implementation)
`void SendItemsToClient(NetworkConnection conn)`

A default interface method that iterates through all `ItemSlots` and calls the abstract `SetSlotLocked` and `SetStoredInstance` methods to synchronize the entire inventory state to a specific client. This is typically used when a player first connects or opens a container.

### GetTotalItemCount (Default Implementation)
`int GetTotalItemCount()`

A default interface method that returns the sum of quantities across all item slots.

### GetItemCount (Default Implementation)
`int GetItemCount(string id)`

A default interface method that returns the total quantity of a specific item (by its `id`) across all slots.
