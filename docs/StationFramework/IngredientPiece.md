# IngredientPiece

The `IngredientPiece` class represents a piece of an ingredient that can be dragged and dropped into a liquid container. It handles physics interactions with the liquid, such as friction and dissolving. This component requires a `Draggable` component.

## Public Constants

| Constant          | Type    | Description                       |
| ----------------- | ------- | --------------------------------- |
| `LIQUID_FRICTION` | `float` | A constant value for liquid friction. |

## Public Properties

| Property                    | Type                | Description                                                                  |
| --------------------------- | ------------------- | ---------------------------------------------------------------------------- |
| `CurrentLiquidContainer`    | `LiquidContainer`   | The liquid container that the ingredient piece is currently in.              |
| `ModelContainer`            | `Transform`         | A reference to the transform of the ingredient piece's model.                |
| `DissolveParticles`         | `ParticleSystem`    | The particle system to play when the ingredient dissolves.                   |
| `DetectLiquid`              | `bool`              | A flag to enable or disable liquid detection.                                |
| `DisableInteractionInLiquid`| `bool`              | A flag to disable interaction with the ingredient piece when it's in a liquid. |
| `LiquidFrictionMultiplier`  | `float`             | A multiplier for the liquid friction.                                        |
| `CurrentDissolveAmount`     | `float`             | The current amount that the ingredient has dissolved (from 0 to 1).          |

## Public Methods

| Method                                      | Return Type | Description                                                                    |
| ------------------------------------------- | ----------- | ------------------------------------------------------------------------------ |
| `DissolveAmount(float amount, bool showParticles = true)` | `void`      | Dissolves the ingredient by a specified amount and optionally shows dissolve particles. |
