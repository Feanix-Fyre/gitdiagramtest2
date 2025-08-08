# Fillable

The `Fillable` class is a component that represents a fillable container.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `LiquidContainer` | `LiquidContainer` | The liquid container. |
| `FillableEnabled` | `bool` | If `true`, the fillable is enabled. |
| `LiquidCapacity_L` | `float` | The liquid capacity in liters. |
| `contents` | `List<Content>` | A list of all contents in the fillable. |

## Methods

### `AddLiquid(string label, float volume, Color color)`

Adds liquid to the fillable.

**Parameters:**

* `label`: The label of the liquid.
* `volume`: The volume of the liquid.
* `color`: The color of the liquid.

### `ResetContents()`

Resets the contents of the fillable.

### `GetLiquidVolume(string label)`

Gets the volume of a liquid.

**Parameters:**

* `label`: The label of the liquid to get the volume of.

**Returns:** `float`

### `GetTotalLiquidVolume()`

Gets the total volume of liquid in the fillable.

**Returns:** `float`
