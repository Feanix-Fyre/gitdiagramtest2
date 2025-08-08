# UtilityPole

The `UtilityPole` class represents a utility pole in the game. It is responsible for drawing the power lines between utility poles and culling them when they are not visible.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `previousPole` | `UtilityPole` | The previous utility pole in the line. |
| `nextPole` | `UtilityPole` | The next utility pole in the line. |
| `Connection1Enabled` | `bool` | If `true`, the first connection is enabled. |
| `Connection2Enabled` | `bool` | If `true`, the second connection is enabled. |
| `LengthFactor` | `float` | The length factor for the power lines. |
| `cable1Connection` | `Transform` | The transform for the first cable connection. |
| `cable2Connection` | `Transform` | The transform for the second cable connection. |
| `cable1Segments` | `List<Transform>` | A list of transforms for the segments of the first cable. |
| `cable2Segments` | `List<Transform>` | A list of transforms for the segments of the second cable. |
| `Cable1Container` | `Transform` | The container for the first cable. |
| `Cable2Container` | `Transform` | The container for the second cable. |

## Methods

### `Orient()`

Orients the utility pole to face the next pole in the line.

### `DrawLines()`

Draws the power lines between the utility poles.
