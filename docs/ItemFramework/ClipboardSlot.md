# ClipboardSlot

Inherits from `HotbarSlot`.

## Description

This class represents a special type of `HotbarSlot` for a clipboard. It overrides the `ClearStoredInstance` method to do nothing, which likely prevents the clipboard item from being accidentally dropped or removed from the player's inventory.

## Methods

### ClearStoredInstance
`public override void ClearStoredInstance(bool _internal = false)`

Overrides the base method. The implementation is empty, effectively preventing the item in this slot from being cleared.
