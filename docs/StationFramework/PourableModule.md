# PourableModule

The `PourableModule` class is a module that allows an item to be poured. It inherits from the `ItemModule` class.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `LiquidType` | `string` | The type of liquid that is poured. |
| `PourRate` | `float` | The rate at which the liquid is poured. |
| `AngleFromUpToPour` | `float` | The angle from the up vector at which the liquid will start to pour. |
| `OnlyEmptyOverFillable` | `bool` | If `true`, the liquid will only be poured when the item is over a fillable container. |
| `LiquidCapacity_L` | `float` | The capacity of the liquid in liters. |
| `LiquidColor` | `Color` | The color of the liquid. |
| `DefaultLiquid_L` | `float` | The default amount of liquid in the container. |
| `PourParticles` | `ParticleSystem[]` | An array of particle systems for the pour effect. |
| `PourPoint` | `Transform` | The point from which the liquid is poured. |
| `LiquidContainer` | `LiquidContainer` | The liquid container. |
| `Draggable` | `Draggable` | The draggable component. |
| `DraggableConstraint` | `DraggableConstraint` | The draggable constraint. |
| `PourSound` | `AudioSourceController` | The audio source for the pour sound. |
| `PourParticlesColor` | `Color` | The color of the pour particles. |
| `ParticleMinMultiplier` | `float` | The minimum multiplier for the particle size. |
| `ParticleMaxMultiplier` | `float` | The maximum multiplier for the particle size. |
| `IsPouring` | `bool` | Returns `true` if the liquid is currently being poured. |
| `NormalizedPourRate` | `float` | The normalized pour rate. |
| `LiquidLevel` | `float` | The current level of the liquid. |
| `NormalizedLiquidLevel` | `float` | The normalized liquid level. |

## Methods

### `ActivateModule(StationItem item)`

Activates the module.

**Parameters:**

* `item`: The station item to activate the module for.

### `ChangeLiquidLevel(float change)`

Changes the liquid level.

**Parameters:**

* `change`: The amount to change the liquid level by.

### `SetLiquidLevel(float level)`

Sets the liquid level.

**Parameters:**

* `level`: The level to set.
