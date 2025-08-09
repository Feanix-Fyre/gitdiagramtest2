# AvatarSeat

The `AvatarSeat` class is a component that represents a seat that an avatar can occupy. It provides points for sitting and accessing the seat, and it keeps track of the `NPC` that is currently occupying it.

## Properties

-   `SittingPoint`: A `Transform` that defines the position and rotation of the avatar when sitting.
-   `AccessPoint`: A `Transform` that defines the point from which the avatar can access the seat.
-   `IsOccupied`: A boolean that is `true` if the seat is currently occupied.
-   `Occupant`: The `NPC` that is currently occupying the seat.

## Methods

### `SetOccupant(NPC npc)`

Sets the occupant of the seat. If the seat is already occupied, a warning is logged to the console.
