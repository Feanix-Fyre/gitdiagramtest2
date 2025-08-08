# PlayerVisibility

The `PlayerVisibility` class is responsible for calculating the visibility of a player to NPCs. It takes into account various factors, such as the player's current visibility attributes, the environment, and any objects that may be obscuring the player.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `CurrentVisibility` | `float` | The current visibility of the player. |
| `activeAttributes` | `List<VisibilityAttribute>` | A list of all active visibility attributes on the player. |
| `filteredAttributes` | `List<VisibilityAttribute>` | A list of all filtered visibility attributes on the player. |
| `visibilityCheckMask` | `LayerMask` | The layer mask to use when checking for visibility. |
| `visibilityPoints` | `List<Transform>` | A list of points on the player to check for visibility from. |
| `HighestVisionEvent` | `VisionEvent` | The highest vision event that has occurred for the player. |

## Methods

### `GetAttribute(string name)`

Gets a visibility attribute by name.

**Parameters:**

* `name`: The name of the attribute to get.

**Returns:** `VisibilityAttribute`

### `CalculateExposureToPoint(Vector3 point, float checkRange = 50f, NPC checkingNPC = null)`

Calculates the exposure of the player to a point.

**Parameters:**

* `point`: The point to check for exposure to.
* `checkRange`: The range to check for exposure within.
* `checkingNPC`: The NPC that is checking for exposure.

**Returns:** `float`
