# Hair

The `Hair` class is a component that represents a hair style for an avatar. It inherits from the `Accessory` class and adds functionality to hide specific parts of the hair when a hat or other head accessory is worn.

## Properties

-   `BlockedByHat`: A boolean that indicates whether the hair is currently being blocked by a hat.

## Methods

### `SetBlockedByHat(bool blocked)`

Sets whether the hair should be blocked by a hat. If `true`, it calls the `BlockHair()` method; otherwise, it calls `UnBlockHair()`.

### `BlockHair()`

Hides the parts of the hair that are designated to be hidden when a hat is worn.

### `UnBlockHair()`

Shows the parts of the hair that were hidden by `BlockHair()`.
