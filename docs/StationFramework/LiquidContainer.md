# LiquidContainer

The `LiquidContainer` class is a component that represents a container for liquid.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Viscosity` | `float` | The viscosity of the liquid. |
| `AdjustMurkiness` | `bool` | If `true`, the murkiness of the liquid will be adjusted based on the time of day. |
| `LiquidVolume` | `LiquidVolume` | The liquid volume. |
| `Collider` | `LiquidVolumeCollider` | The collider for the liquid volume. |
| `ColliderTransform_Min` | `Transform` | The transform of the collider when the container is empty. |
| `ColliderTransform_Max` | `Transform` | The transform of the collider when the container is full. |
| `MaxLevel` | `float` | The maximum level of the liquid. |
| `CurrentLiquidLevel` | `float` | The current level of the liquid. |
| `LiquidColor` | `Color` | The color of the liquid. |

## Methods

### `SetLiquidLevel(float level, bool debug = false)`

Sets the level of the liquid.

**Parameters:**

* `level`: The level to set.
* `debug`: If `true`, the liquid level will be logged to the console.

### `SetLiquidColor(Color color, bool setColorVariable = true, bool updateLigting = true)`

Sets the color of the liquid.

**Parameters:**

* `color`: The color to set.
* `setColorVariable`: If `true`, the `LiquidColor` property will be set.
* `updateLigting`: If `true`, the lighting will be updated.
