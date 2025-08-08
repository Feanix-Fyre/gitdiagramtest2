# PourableAngleLimit

The `PourableAngleLimit` class controls the pouring angle of a `PourableModule` based on its liquid level. It adjusts the pouring angle to be smaller when the container is full and larger when it's empty.

## Public Properties

| Property           | Type                  | Description                                                  |
| ------------------ | --------------------- | ------------------------------------------------------------ |
| `Pourable`         | `PourableModule`      | A reference to the `PourableModule` component.               |
| `Constraint`       | `DraggableConstraint` | A reference to the `DraggableConstraint` component.          |
| `AngleAtMaxFill`   | `float`               | The maximum angle when the container is full.                |
| `AngleAtMinFill`   | `float`               | The maximum angle when the container is empty.               |
| `PourAngleMaxFill` | `float`               | The pouring angle when the container is full.                |
| `PourAngleMinFill` | `float`               | The pouring angle when the container is empty.               |
