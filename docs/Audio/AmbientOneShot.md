# AmbientOneShot

The `AmbientOneShot` class plays a one-shot audio clip at random intervals, with constraints on when and where it can play.

## EPlayTime (Enum)

| Value | Description                             |
| ----- | --------------------------------------- |
| `All` | The audio can play at any time.         |
| `Day` | The audio can only play during the day. |
| `Night`| The audio can only play at night.       |

## Public Properties

| Property        | Type                  | Description                                                    |
| --------------- | --------------------- | -------------------------------------------------------------- |
| `Audio`         | `AudioSourceController` | A reference to the `AudioSourceController` to be played.       |
| `Volume`        | `float`               | The volume of the audio clip.                                  |
| `ChancePerHour` | `float`               | The chance per hour that the audio clip will play.             |
| `CooldownTime`  | `int`                 | The cooldown time in minutes between plays.                    |
| `PlayTime`      | `EPlayTime`           | The time of day when the audio can play.                       |
| `MinDistance`   | `float`               | The minimum distance from the player for the audio to play.    |
| `MaxDistance`   | `float`               | The maximum distance from the player for the audio to play.    |
