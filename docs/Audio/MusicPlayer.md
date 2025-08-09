# MusicPlayer

The `MusicPlayer` class is a persistent singleton that manages the playback of music tracks in the game. It selects which track to play based on their priority and enabled status.

## Public Static Properties

| Property                    | Type    | Description                                                 |
| --------------------------- | ------- | ----------------------------------------------------------- |
| `TimeSinceLastAmbientTrack` | `float` | The time in seconds since the last ambient track was played. |

## Public Properties

| Property            | Type                  | Description                                                        |
| ------------------- | --------------------- | ------------------------------------------------------------------ |
| `Tracks`            | `List<MusicTrack>`    | A list of all music tracks in the game.                            |
| `MusicMixer`        | `AudioMixerGroup`     | The audio mixer for the music.                                     |
| `DefaultSnapshot`   | `AudioMixerSnapshot`  | The default audio snapshot for the music mixer.                    |
| `DistortedSnapshot` | `AudioMixerSnapshot`  | The distorted audio snapshot for the music mixer.                  |
| `IsPlaying`         | `bool`                | A boolean indicating whether a music track is currently playing.   |

## Public Methods

| Method                                      | Return Type | Description                                                              |
| ------------------------------------------- | ----------- | ------------------------------------------------------------------------ |
| `SetMusicDistorted(bool distorted, float transition = 5f)` | `void`      | Transitions the music mixer to the distorted or default snapshot.      |
| `SetTrackEnabled(string trackName, bool enabled)` | `void`      | Enables or disables a music track by name.                               |
| `StopTrack(string trackName)`               | `void`      | Stops a music track by name.                                             |
| `StopAndDisableTracks()`                    | `void`      | Stops and disables all music tracks.                                     |
