# AvatarSeatSet

The `AvatarSeatSet` class is a component that manages a collection of `AvatarSeat` components. It provides methods to find an available seat from the set.

## Properties

-   `Seats`: An array of `AvatarSeat` components managed by this set.

## Methods

### `GetFirstFreeSeat()`

Returns the first available seat in the `Seats` array. If no seat is free, it logs a warning and returns the first seat in the array.

### `GetRandomFreeSeat()`

Returns a random available seat from the `Seats` array. If no seat is free, it logs a warning and returns the first seat in the array.
