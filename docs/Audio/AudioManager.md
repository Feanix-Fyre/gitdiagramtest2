# AudioManager

The `AudioManager` class is a persistent singleton that manages all audio in the game. It controls the volume of different audio types, manages audio mixers, and handles transitions between audio snapshots.

## Public Constants

| Constant                          | Type    | Description                               |
| --------------------------------- | ------- | ----------------------------------------- |
| `MIN_WORLD_MUSIC_VOLUME_MULTIPLIER` | `float` | The minimum volume multiplier for world music. |
| `MUSIC_FADE_TIME`                 | `float` | The time it takes for music to fade.      |

## Public Properties

| Property                   | Type                  | Description                                                                  |
| -------------------------- | --------------------- | ---------------------------------------------------------------------------- |
| `onSettingsChanged`        | `UnityEvent`          | An event that is invoked when the audio settings are changed.                |
| `DoorOpen`                 | `AudioSourceController` | The audio controller for the generic door opening sound.                     |
| `DoorClose`                | `AudioSourceController` | The audio controller for the generic door closing sound.                     |
| `MainGameMixer`            | `AudioMixerGroup`     | The main audio mixer for the game.                                           |
| `MenuMixer`                | `AudioMixerGroup`     | The audio mixer for the menu.                                                |
| `MusicMixer`               | `AudioMixerGroup`     | The audio mixer for the music.                                               |
| `DefaultSnapshot`          | `AudioMixerSnapshot`  | The default audio snapshot.                                                  |
| `DistortedSnapshot`        | `AudioMixerSnapshot`  | The distorted audio snapshot.                                                |
| `MasterVolume`             | `float`               | The master volume level.                                                     |
| `AmbientVolume`            | `float`               | The ambient volume level, scaled by the master volume.                       |
| `UnscaledAmbientVolume`    | `float`               | The ambient volume level, not scaled by the master volume.                   |
| `FootstepsVolume`          | `float`               | The footsteps volume level, scaled by the master volume.                     |
| `UnscaledFootstepsVolume`  | `float`               | The footsteps volume level, not scaled by the master volume.                 |
| `FXVolume`                 | `float`               | The FX volume level, scaled by the master volume.                            |
| `UnscaledFXVolume`         | `float`               | The FX volume level, not scaled by the master volume.                        |
| `UIVolume`                 | `float`               | The UI volume level, scaled by the master volume.                            |
| `UnscaledUIVolume`         | `float`               | The UI volume level, not scaled by the master volume.                        |
| `MusicVolume`              | `float`               | The music volume level, scaled by the master volume.                         |
| `UnscaledMusicVolume`      | `float`               | The music volume level, not scaled by the master volume.                     |
| `VoiceVolume`              | `float`               | The voice volume level, scaled by the master volume.                         |
| `UnscaledVoiceVolume`      | `float`               | The voice volume level, not scaled by the master volume.                     |
| `WorldMusicVolumeMultiplier` | `float`             | A multiplier for the volume of world music.                                  |

## Public Methods

| Method                                      | Return Type | Description                                                                    |
| ------------------------------------------- | ----------- | ------------------------------------------------------------------------------ |
| `GetScaledMusicVolumeMultiplier(float min)` | `float`     | Gets the scaled music volume multiplier.                                       |
| `SetGameVolumeMultipler(float value)`       | `void`      | Sets the game volume multiplier.                                               |
| `SetDistorted(bool distorted, float transition = 5f)` | `void`      | Transitions to the distorted or default audio snapshot.                      |
| `GetVolume(EAudioType audioType, bool scaled = true)` | `float`     | Gets the volume for a specific audio type, with an option for scaling.       |
| `SetMasterVolume(float volume)`             | `void`      | Sets the master volume.                                                        |
| `SetVolume(EAudioType type, float volume)`   | `void`      | Sets the volume for a specific audio type.                                     |
