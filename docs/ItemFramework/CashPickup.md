# CashPickup

Inherits from `ItemPickup`.

## Description

This class represents a physical pickup for cash in the game world. Instead of giving the player a "cash" item, interacting with this object directly adds its monetary `Value` to the player's cash balance via the `MoneyManager`.

## Fields

-   **Value**: `float`
    -   The amount of money this pickup is worth.

## Methods

### Hovered
`protected override void Hovered()`

Overrides the base method to set a custom interaction message that includes the formatted cash value (e.g., "Pick up $10.00").

### CanPickup
`protected override bool CanPickup()`

Overrides the base method. It always returns `true`, as there are no special conditions required to pick up cash.

### Pickup
`protected override void Pickup()`

Overrides the base method. It calls `ChangeCashBalance` on the `MoneyManager` to add the `Value` to the player's balance, and then calls the base `Pickup` method to handle destroying the pickup object.
