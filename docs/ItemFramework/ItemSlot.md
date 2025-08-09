# ItemSlot

A class representing a single slot within an inventory or container.

## Description

This class holds an `ItemInstance` and manages its quantity and state. It works closely with an `IItemSlotOwner` (like a player inventory or a storage box) to synchronize its state across the network. It also supports filtering to restrict which items it can hold and locking to prevent modification.

## Key Properties

-   **ItemInstance**: `ItemInstance` (read-only) - The item currently in this slot. Can be `null`.
-   **SlotOwner**: `IItemSlotOwner` (read-only) - The inventory or container that this slot belongs to.
-   **Quantity**: `int` (read-only) - The quantity of the item in the slot. Returns 0 if the slot is empty.
-   **IsAtCapacity**: `bool` (read-only) - True if the item's quantity has reached its `StackLimit`.
-   **IsLocked**: `bool` (read-only) - True if the slot is currently locked by an `ItemSlotLock`.
-   **IsRemovalLocked / IsAddLocked**: `bool` - Flags to prevent items from being removed from or added to the slot, separate from the main lock.

## Events (Actions)

-   **onItemDataChanged**: Invoked when the data of the `ItemInstance` changes (e.g., quantity).
-   **onItemInstanceChanged**: Invoked when the `ItemInstance` itself is replaced with a new one or cleared.
-   **onLocked / onUnlocked**: Invoked when the slot's lock state changes.

## Core Logic

-   **Networking**: The `ItemSlot` itself is not a `NetworkBehaviour`. Instead, it relies on its `SlotOwner` to synchronize its state. When a change is made (e.g., `SetStoredItem`), it calls a method on the `SlotOwner` (e.g., `SetStoredInstance`), which is expected to be an RPC that broadcasts the change to clients. The `_internal` parameter in many methods is used to bypass this RPC call when the method is being executed on a client *as a result* of receiving an RPC, preventing infinite loops.
-   **Stacking**: The `InsertItem` method handles adding items to the slot. If the slot is empty, it sets the new item. If it contains a stackable item, it increases the quantity.
-   **Filtering**: The `DoesItemMatchFilters` method checks an item against a list of `ItemFilter`s to determine if it's allowed in the slot.
-   **Locking**: The `ApplyLock` and `RemoveLock` methods control a hard lock on the slot, preventing any modifications. This is used for things like crafting processes where the input items should not be touchable.

## Public Methods

### SetStoredItem
`public virtual void SetStoredItem(ItemInstance instance, bool _internal = false)`

Sets the `ItemInstance` for this slot, replacing any existing item.

### ClearStoredInstance
`public virtual void ClearStoredInstance(bool _internal = false)`

Removes the `ItemInstance` from this slot, making it empty.

### ChangeQuantity / SetQuantity
`public void ChangeQuantity(int change, bool _internal = false)` and `public void SetQuantity(int amount, bool _internal = false)`

Modifies the quantity of the item in the slot.

### AddFilter
`public void AddFilter(ItemFilter filter)`

Adds an `ItemFilter` to this slot to restrict the types of items it can hold.

### ApplyLock / RemoveLock
`public void ApplyLock(...)` and `public void RemoveLock(...)`

Applies or removes a lock on the slot, preventing modification.
