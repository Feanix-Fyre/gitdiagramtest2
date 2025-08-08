# Investigation

The `Investigation` class represents a police investigation into a player. It is responsible for tracking the progress of the investigation.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `CurrentProgress` | `float` | The current progress of the investigation. |
| `Target` | `Player` | The player who is the target of the investigation. |

## Constructors

### `Investigation(Player target)`

Initializes a new instance of the `Investigation` class.

**Parameters:**

* `target`: The player who is the target of the investigation.

## Methods

### `ChangeProgress(float progress)`

Changes the progress of the investigation.

**Parameters:**

* `progress`: The amount to change the progress by.
