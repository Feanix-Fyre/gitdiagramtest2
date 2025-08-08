# AudioSourceController

The `AudioSourceController` class is a wrapper for Unity's `AudioSource` component. It provides more control over the audio source, including volume and pitch management, and integration with the `AudioManager`. This component requires an `AudioSource`.

## Public Properties

| Property           | Type          | Description                                                                  |
| ------------------ | ------------- | ---------------------------------------------------------------------------- |
| `DEBUG`            | `bool`        | A flag to enable debug logging.                                              |
| `AudioSource`      | `AudioSource` | A reference to the `AudioSource` component.                                  |
| `AudioType`        | `EAudioType`  | The type of audio this controller manages.                                   |
| `DefaultVolume`    | `float`       | The default volume of the audio source.                                      |
| `RandomizePitch`   | `bool`        | A flag to enable or disable randomizing the pitch of the audio source.      |
| `MinPitch`         | `float`       | The minimum pitch to use when `RandomizePitch` is enabled.                   |
| `MaxPitch`         | `float`       | The maximum pitch to use when `RandomizePitch` is enabled.                   |
| `VolumeMultiplier` | `float`       | A multiplier for the volume of the audio source.                             |
| `PitchMultiplier`  | `float`       | A multiplier for the pitch of the audio source.                              |
| `Volume`           | `float`       | The current volume of the audio source.                                      |
| `isPlaying`        | `bool`        | A boolean indicating whether the audio source is currently playing.          |

## Public Methods

| Method                                      | Return Type | Description                                                                    |
| ------------------------------------------- | ----------- | ------------------------------------------------------------------------------ |
| `SetVolume(float volume)`                   | `void`      | Sets the volume of the audio source.                                           |
| `ApplyVolume()`                             | `void`      | Applies the current volume settings to the audio source.                       |
| `ApplyPitch()`                              | `void`      | Applies the current pitch settings to the audio source.                        |
| `Play()`                                    | `void`      | Plays the audio source.                                                        |
| `PlayOneShot(bool duplicateAudioSource = false)` | `void`      | Plays the audio clip as a one-shot. If `duplicateAudioSource` is true, it will create a new GameObject to play the sound from. |
| `Stop()`                                    | `void`      | Stops the audio source.                                                        |
