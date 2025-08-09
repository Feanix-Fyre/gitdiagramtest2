# DealerStaticDoor

Inherits from `StaticDoor`.

## Description

This class represents a specific type of static door belonging to a `Dealer`. It extends the base `StaticDoor` to add a custom condition for when a player can knock.

## Fields

-   **Dealer**: `Dealer`
    -   A reference to the `Dealer` NPC who owns or operates from behind this door.

## Methods

### IsKnockValid
`protected override bool IsKnockValid(out string message)`

Overrides the base method to check if a player is allowed to knock. A knock is considered invalid if there is no one inside the building and the associated `Dealer` is far away from the door.

-   **Parameters:**
    -   `message`: An `out` parameter that will be set to a message explaining why the knock is invalid (e.g., "[Dealer] is out dealing").
-   **Returns:** `false` if the dealer is out, otherwise returns the result of the base class's check.
