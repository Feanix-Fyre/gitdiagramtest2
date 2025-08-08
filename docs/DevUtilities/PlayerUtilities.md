# PlayerUtilities

The `PlayerUtilities` class is a static utility class that provides methods for controlling the player.

## Methods

### `OpenMenu()`

Opens a menu. This method frees the mouse, disables looking, disables movement, disables the inventory, and hides the crosshair.

### `CloseMenu(bool reenableLookInstantly = false, bool reenableInventory = true)`

Closes a menu. This method locks the mouse, enables looking, enables movement, enables the inventory, and shows the crosshair.

**Parameters:**

* `reenableLookInstantly`: If `true`, looking will be re-enabled instantly.
* `reenableInventory`: If `true`, the inventory will be re-enabled.
