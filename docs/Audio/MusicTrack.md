# MusicTrack

The `MusicTrack` class represents a single music track that can be played by the `MusicPlayer`. It controls the fading in and out of the track. This component requires an `AudioSourceController`.

## Public Properties

| Property           | Type                  | Description                                                                 |
| ------------------ | --------------------- | --------------------------------------------------------------------------- |
| `Enabled`          | `bool`                | A flag indicating whether the track is enabled.                             |
| `TrackName`        | `string`              | The name of the track.                                                      |
| `Priority`         | `int`                 | The priority of the track. Higher priority tracks will be played over lower priority tracks. |
| `FadeInTime`       | `float`               | The time it takes for the track to fade in.                                 |
| `FadeOutTime`      | `float`               | The time it takes for the track to fade out.                                |
| `Controller`       | `AudioSourceController` | The audio source controller for the track.                                  |
| `VolumeMultiplier` | `float`               | A multiplier for the volume of the track.                                   |
| `AutoFadeOut`      | `bool`                | A flag indicating whether the track should automatically fade out when it's finished playing. |
| `IsPlaying`        | `bool`                | A boolean indicating whether the track is currently playing.                |

## Public Methods

| Method    | Return Type | Description         |
| --------- | ----------- | ------------------- |
| `Enable()`  | `void`      | Enables the track.  |
| `Disable()` | `void`      | Disables the track. |
| `Play()`    | `void`      | Plays the track.    |
| `Stop()`    | `void`      | Stops the track.    |
