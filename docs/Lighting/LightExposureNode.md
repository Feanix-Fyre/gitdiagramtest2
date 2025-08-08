# LightExposureNode

The `LightExposureNode` class is a component that represents a node that can be exposed to light.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `ambientExposure` | `float` | The ambient exposure of the node. |
| `sources` | `Dictionary<UsableLightSource, float>` | A dictionary of all light sources that are exposing the node. |

## Methods

### `GetTotalExposure(out float growSpeedMultiplier)`

Gets the total exposure of the node.

**Parameters:**

* `growSpeedMultiplier`: Returns the grow speed multiplier for the node.

**Returns:** `float`

### `AddSource(UsableLightSource source, float lightAmount)`

Adds a light source to the node.

**Parameters:**

* `source`: The light source to add.
* `lightAmount`: The amount of light to add.

### `RemoveSource(UsableLightSource source)`

Removes a light source from the node.

**Parameters:**

* `source`: The light source to remove.
