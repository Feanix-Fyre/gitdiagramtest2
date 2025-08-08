# AudioZone

The `AudioZone` class defines a zone in the world where specific audio tracks are played. The volume of the tracks is affected by the player's distance from the zone, the time of day, and any active `AudioZoneModifierVolume`s.

## Track (Inner Class)

Represents an audio track to be played within the `AudioZone`.

| Property      | Type                  | Description                                                              |
| ------------- | --------------------- | ------------------------------------------------------------------------ |
| `Source`      | `AudioSourceController` | The audio source to be played.                                           |
| `Volume`      | `float`               | The base volume of the track.                                            |
| `StartTime`   | `int`                 | The time of day (in 24-hour format) when the track starts playing.     |
| `EndTime`     | `int`                 | The time of day (in 24-hour format) when the track stops playing.      |
| `FadeTime`    | `int`                 | The time in minutes it takes for the track to fade in and out.           |

### Public Methods (Track)

| Method                    | Return Type | Description                                                     |
| ------------------------- | ----------- | --------------------------------------------------------------- |
| `Init()`                  | `void`      | Initializes the track's fade times.                             |
| `Update(float multiplier)`| `void`      | Updates the track's volume based on the given multiplier.       |
| `UpdateTimeMultiplier(int time)` | `void`      | Updates the track's time-based volume multiplier.               |

## Public Constants

| Constant             | Type    | Description                               |
| -------------------- | ------- | ----------------------------------------- |
| `VOLUME_CHANGE_RATE` | `float` | The rate at which the volume changes.     |
| `ROLLOFF_SCALE`      | `float` | A scale factor for the audio rolloff.     |

## Public Properties

| Property        | Type                                    | Description                                                              |
| --------------- | --------------------------------------- | ------------------------------------------------------------------------ |
| `MaxDistance`   | `float`                                 | The maximum distance from the zone where the audio can be heard.         |
| `Tracks`        | `List<Track>`                           | A list of audio tracks to be played in the zone.                         |
| `Modifiers`     | `Dictionary<AudioZoneModifierVolume, float>` | A dictionary of active audio zone modifiers.                             |
| `VolumeModifier`| `float`                                 | A modifier for the volume of the zone.                                   |

## Public Methods

| Method                                      | Return Type | Description                               |
| ------------------------------------------- | ----------- | ----------------------------------------- |
| `AddModifier(AudioZoneModifierVolume modifier, float value)` | `void`      | Adds a modifier to the audio zone.        |
| `RemoveModifier(AudioZoneModifierVolume modifier)` | `void`      | Removes a modifier from the audio zone.   |
