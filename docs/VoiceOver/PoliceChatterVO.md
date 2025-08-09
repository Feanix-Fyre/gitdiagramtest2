# PoliceChatterVO

The `PoliceChatterVO` class is responsible for playing police chatter voice-overs. It inherits from the `VOEmitter` class.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `StartBeep` | `AudioSourceController` | The sound to play at the beginning of the chatter. |
| `StartEndBeep` | `AudioSourceController` | The sound to play at the end of the chatter. |
| `Static` | `AudioSourceController` | The static sound to play during the chatter. |

## Methods

### `Play(EVOLineType lineType)`

Plays a voice-over. If the line type is `PoliceChatter`, it will play a police chatter voice-over. Otherwise, it will call the base class's `Play` method.

**Parameters:**

* `lineType`: The type of voice-over to play.
